using Newtonsoft.Json;
using RoboSiga.Helpers;
using RoboSiga.Models;
using RoboSiga.Models.JsonResult;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace RoboSiga.Process
{
    public class SigaProcess : IProcess
    {
        #region Private properties
        private int etapa = 0;
        private RequestHelper requestHelper = null;
        private HtmlHelper htmlHelper = null;
        private string ret = null;
        #endregion

        #region Public methods
        public BaseResult Start()
        {
            etapa = 0;
            BaseResult result = new BaseResult();
            try
            {
                while (etapa < 5)
                {
                    switch (etapa)
                    {
                        case 0:
                            AccessWebSite();
                            break;
                        case 1:
                            DoLogon();
                            break;
                        case 2:
                            Grades();
                            break;
                        case 3:
                            GetGradeValues();
                            break;
                        case 4:
                            result.Success = true;
                            result.Message = "Processo finalizado com sucesso";
                            break;
                    }
                    etapa++;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                ret = ex.Message;
            }
            return result;
        }

        public void Error()
        {
            SendMail(ret);
        }

        public void Success()
        {
            SendMail(ret);
        }
        #endregion

        #region Métodos privados
        private void AccessWebSite()
        {
            try
            {
                requestHelper = new RequestHelper("https://siga.cps.sp.gov.br/aluno/login.aspx");
                requestHelper.Accept("text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3");
                requestHelper.UserAgent("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36");
                requestHelper.AddRequestHeader("Accept-Encoding", "gzip, deflate, br");
                requestHelper.AddRequestHeader("Accept-Language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
                requestHelper.ExecuteRequest("GET");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DoLogon()
        {
            try
            {
                requestHelper.LoadRequest("https://siga.cps.sp.gov.br/aluno/login.aspx");
                string postData = SigaHelper.PostDataLogon(
                    ConfigurationManager.AppSettings["UsuarioSiga"].ToString(),
                    ConfigurationManager.AppSettings["SenhaSiga"].ToString()
                );
                requestHelper.Host("siga.cps.sp.gov.br");
                requestHelper.ContentType("application/x-www-form-urlencoded");
                requestHelper.UserAgent("Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 76.0.3809.132 Safari / 537.36");
                requestHelper.Accept("*/*");
                requestHelper.KeepAlive(true);
                requestHelper.Referer("https://siga.cps.sp.gov.br/aluno/login.aspx");
                requestHelper.AddRequestHeader(HttpRequestHeader.Cookie, "ASP.NET_SessionId = n5dfhwy2y405jk55z0x25k55");
                requestHelper.AddRequestHeader("Origin", "https://siga.cps.sp.gov.br");

                requestHelper.ExecuteRequest("POST", postData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Grades()
        {
            try
            {
                requestHelper.LoadRequest("https://siga.cps.sp.gov.br/aluno/notasparciais.aspx");
                requestHelper.Host("siga.cps.sp.gov.br");
                requestHelper.ContentType("application/x-www-form-urlencoded");
                requestHelper.UserAgent("Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 76.0.3809.132 Safari / 537.36");
                requestHelper.Accept("*/*");
                requestHelper.KeepAlive(true);
                requestHelper.Referer("https://siga.cps.sp.gov.br/aluno/login.aspx");
                requestHelper.AddRequestHeader(HttpRequestHeader.Cookie, "ASP.NET_SessionId = n5dfhwy2y405jk55z0x25k55");
                requestHelper.AddRequestHeader("Origin", "https://siga.cps.sp.gov.br");
                requestHelper.ExecuteRequest("GET");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetGradeValues()
        {
            try
            {
                htmlHelper = new HtmlHelper(requestHelper.GetResponseBody());
                string json = htmlHelper.GetElementByProperty(htmlHelper.GetElementsByTagName("input"), "name", "GXState").GetAttributeValue("value", string.Empty);
                RootObject grades = JsonConvert.DeserializeObject<RootObject>(json);
                Discipline d = null;
                Grade g = null;
                List<Discipline> disciplines = new List<Discipline>();
                List<Grade> gradesResult = new List<Grade>();
                if (grades.Acd_alunonotasparciais_sdt == null || grades.Acd_alunonotasparciais_sdt.Count == 0)
                {
                    throw new Exception("Não foi possível localizar os dados das disciplinas solicitadas");
                }
                foreach (AcdAlunonotasparciaisSdt disciplina in grades.Acd_alunonotasparciais_sdt)
                {
                    d = new Discipline() { Name = disciplina.ACD_DisciplinaNome };
                    foreach (Avaliacao av in disciplina.Avaliacoes)
                    {
                        g = new Grade() { Name = av.ACD_PlanoEnsinoAvaliacaoSufixo };
                        foreach (Nota nota in av.Notas)
                        {
                            g.Date = nota.ACD_PlanoEnsinoAvaliacaoParcialDataLancamento;
                            g.Value = nota.ACD_PlanoEnsinoAvaliacaoParcialNota;
                        }
                        d.Grades.Add(g);
                    }
                    disciplines.Add(d);
                }
                StringBuilder sb = new StringBuilder();
                foreach (Discipline discipline in disciplines)
                {
                    sb.AppendLine(discipline.GetValues());
                }
                SendMail(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SendMail(string corpo)
        {
            MailHelper mailHelper = new MailHelper(
                    ConfigurationManager.AppSettings["EmailNotificador"].ToString(),
                    ConfigurationManager.AppSettings["SenhaEmailNotificador"].ToString(),
                    ConfigurationManager.AppSettings["ServidorSmtp"].ToString()
                );
            mailHelper.SendMail(
                    ConfigurationManager.AppSettings["EmailDestino"].ToString(),
                    "Robô Notas SIGA",
                    corpo
                );
        } 
        #endregion
    }
}
