using System.Net.Mail;

namespace RoboSiga.Helpers
{
    class MailHelper
    {
        public string SenderMail { get; set; }
        public string Smtp { get; set; }
        public string Password { get; set; }

        public MailHelper(string senderMail, string password, string smtpServer)
        {
            this.SenderMail = senderMail;
            this.Password = password;
            this.Smtp = smtpServer;
        }

        public void SendMail(string receiverMail, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(this.SenderMail);
            mail.To.Add(receiverMail);
            mail.Subject = subject;
            mail.Body = body;
            SmtpClient smtp = new SmtpClient(this.Smtp);
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(this.SenderMail, this.Password);
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}
