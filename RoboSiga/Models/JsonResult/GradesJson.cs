using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboSiga.Models.JsonResult
{
    public class GradesJson
    {
        public List<AlunoValues> Acd_alunonotasparciais_sdt { get; set; }
    }

    public class AlunoValues
    {
        public long ACD_AlunoId { get; set; }
        public long UNI_UnidadeId { get; set; }
        public long ACD_CursoId { get; set; }
        public long ACD_Periodoid { get; set; }
        public long ACD_EstruturaCurricularId { get; set; }
        public string ACD_DisciplinaSigla { get; set; }
        public string ACD_DisciplinaNome { get; set; }
        public long ACD_AlunoHistoricoItemId { get; set; }
        public long ACD_AlunoHistoricoItemPeriodoOferecimentoId { get; set; }
        public long ACD_AlunoHistoricoItemMediaFinal { get; set; }
        public long ACD_AlunoHistoricoItemQtdFaltas { get; set; }
        public long ACD_AlunoHistoricoItemFrequencia { get; set; }
        public long ACD_AlunoHistoricoTipoObservacaoId { get; set; }
        public long ACD_AlunoHistoricoItemUnidadeId { get; set; }
        public long ACD_AlunoHistoricoItemPeriodoId { get; set; }
        public long ACD_AlunoHistoricoItemCursoId { get; set; }
        public long ACD_AlunoHistoricoItemEstruturaCurricularId { get; set; }
        public string ACD_AlunoHistoricoItemDesistenciaData { get; set; }
        public long ACD_AlunoHistoricoItemTurmaId { get; set; }
        public long ACD_AlunoHistoricoTipoMatriculaSituacaoId { get; set; }
        public long ACD_AlunoHistoricoItemProfessorId { get; set; }
        public long GER_TipoMotivoDeleteId { get; set; }
        public long ACD_AlunoHistoricoItemAprovada { get; set; }
        public long ACD_AlunoHistoricoItemFlagImportacao { get; set; }
        public string ACD_AlunoHistoricoItemDisciplinaSigla { get; set; }
        public long ACD_AlunoHistoricoItemTipoDisciplina { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
    }

    public class Avaliacao
    {
        public long ACD_PlanoEnsinoAvaliacaoId { get; set; }
        public long ACD_PeriodoOferecimentoId { get; set; }
        public long ACD_ProfessorId { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoTitulo { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoDescricao { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoObjetivo { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoSufixo { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoPeso { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoDataPrevista { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoDataProva { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoDataPublicacao { get; set; }
        public List<Nota> Notas { get; set; }

        public int ACD_PlanoEnsinoPublicoFlag { get; set; }
    }

    public class Nota
    {
        public double ACD_PlanoEnsinoAvaliacaoParcialNota { get; set; }
        public string ACD_PlanoEnsinoAvaliacaoParcialDataLancamento { get; set; }
    }

    public class Node2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string LinkTarget { get; set; }
        public bool Expanded { get; set; }
        public bool DynamicLoad { get; set; }
        public string Icon { get; set; }
        public string IconWhenSelected { get; set; }
    }

    public class Node
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string LinkTarget { get; set; }
        public bool Expanded { get; set; }
        public bool DynamicLoad { get; set; }
        public string Icon { get; set; }
        public string IconWhenSelected { get; set; }
        public List<Node2> Nodes { get; set; }
    }

    public class VTREENODECOLLECTIONDATAMPAGE
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string LinkTarget { get; set; }
        public bool Expanded { get; set; }
        public bool DynamicLoad { get; set; }
        public string Icon { get; set; }
        public string IconWhenSelected { get; set; }
        public List<Node> Nodes { get; set; }
    }

    public class VSELECTEDTREENODEMPAGE
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string LinkTarget { get; set; }
        public bool Expanded { get; set; }
        public bool DynamicLoad { get; set; }
        public string Icon { get; set; }
        public string IconWhenSelected { get; set; }
    }

    public class AcdAlunonotasparciaisSdt
    {
        public int ACD_AlunoId { get; set; }
        public int UNI_UnidadeId { get; set; }
        public int ACD_CursoId { get; set; }
        public int ACD_Periodoid { get; set; }
        public int ACD_EstruturaCurricularId { get; set; }
        public string ACD_DisciplinaSigla { get; set; }
        public string ACD_DisciplinaNome { get; set; }
        public int ACD_AlunoHistoricoItemId { get; set; }
        public int ACD_AlunoHistoricoItemPeriodoOferecimentoId { get; set; }
        public double ACD_AlunoHistoricoItemMediaFinal { get; set; }
        public int ACD_AlunoHistoricoItemQtdFaltas { get; set; }
        public double ACD_AlunoHistoricoItemFrequencia { get; set; }
        public int ACD_AlunoHistoricoTipoObservacaoId { get; set; }
        public int ACD_AlunoHistoricoItemUnidadeId { get; set; }
        public int ACD_AlunoHistoricoItemPeriodoId { get; set; }
        public int ACD_AlunoHistoricoItemCursoId { get; set; }
        public int ACD_AlunoHistoricoItemEstruturaCurricularId { get; set; }
        public string ACD_AlunoHistoricoItemDesistenciaData { get; set; }
        public int ACD_AlunoHistoricoItemTurmaId { get; set; }
        public int ACD_AlunoHistoricoTipoMatriculaSituacaoId { get; set; }
        public int ACD_AlunoHistoricoItemProfessorId { get; set; }
        public int GER_TipoMotivoDeleteId { get; set; }
        public int ACD_AlunoHistoricoItemAprovada { get; set; }
        public int ACD_AlunoHistoricoItemFlagImportacao { get; set; }
        public string ACD_AlunoHistoricoItemDisciplinaSigla { get; set; }
        public int ACD_AlunoHistoricoItemTipoDisciplina { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
        public int ACD_PlanoEnsinoPublicoFlag { get; set; }
    }

    public class GXCMPOBJS
    {
        public string MPW0041 { get; set; }
    }

    public class RootObject
    {
        public string _EventName { get; set; }
        public string _EventGridId { get; set; }
        public string _EventRowId { get; set; }
        public string vUNI_UNIDADENOME_MPAGE { get; set; }
        public string vACD_CURSONOME_MPAGE { get; set; }
        public string vSITUACAO_MPAGE { get; set; }
        public string vACD_PERIODODESCRICAO_MPAGE { get; set; }
        public string vGER_TIPOSITUACAOCURSOID_MPAGE { get; set; }
        public string MPW0041 { get; set; }
        public string MPW0041_CMPPGM { get; set; }
        public string MPW0041vPRO_PESSOALNOME { get; set; }
        public string MPW0041vACD_ALUNOCURSOREGISTROACADEMICOCURSO { get; set; }
        public string MPW0041vACD_ALUNOCURSOCICLOATUAL { get; set; }
        public string MPW0041vMENSAGEM { get; set; }
        public string MPW0041vACD_ALUNOCURSOINDICEPP { get; set; }
        public string MPW0041vACD_ALUNOCURSOINDICEPR { get; set; }
        public string MPW0041vMAX_ACD_ALUNOCURSOINDICEPR { get; set; }
        public string MPW0041vSEMESTRESCURSADOS { get; set; }
        public string MPW0041vINTEGRALIZACAOMAX { get; set; }
        public string MPW0041vFALTA { get; set; }
        public string MPW0041GX_FocusControl { get; set; }
        public string nRC_Grid1_00010001 { get; set; }
        public string Grid1ContainerData_00010001 { get; set; }
        public string GRID1_nFirstRecordOnPage_00010001 { get; set; }
        public string GRID1_nEOF_00010001 { get; set; }
        public string nRC_Grid1_00020001 { get; set; }
        public string Grid1ContainerData_00020001 { get; set; }
        public string GRID1_nFirstRecordOnPage_00020001 { get; set; }
        public string GRID1_nEOF_00020001 { get; set; }
        public string nRC_Grid1_00030001 { get; set; }
        public string Grid1ContainerData_00030001 { get; set; }
        public string GRID1_nFirstRecordOnPage_00030001 { get; set; }
        public string GRID1_nEOF_00030001 { get; set; }
        public string nRC_Grid2_0001 { get; set; }
        public string Grid2ContainerData_0001 { get; set; }
        public string nRC_Grid1_00010002 { get; set; }
        public string Grid1ContainerData_00010002 { get; set; }
        public string GRID1_nFirstRecordOnPage_00010002 { get; set; }
        public string GRID1_nEOF_00010002 { get; set; }
        public string nRC_Grid1_00020002 { get; set; }
        public string Grid1ContainerData_00020002 { get; set; }
        public string GRID1_nFirstRecordOnPage_00020002 { get; set; }
        public string GRID1_nEOF_00020002 { get; set; }
        public string nRC_Grid1_00030002 { get; set; }
        public string Grid1ContainerData_00030002 { get; set; }
        public string GRID1_nFirstRecordOnPage_00030002 { get; set; }
        public string GRID1_nEOF_00030002 { get; set; }
        public string nRC_Grid2_0002 { get; set; }
        public string Grid2ContainerData_0002 { get; set; }
        public string nRC_Grid1_00010003 { get; set; }
        public string Grid1ContainerData_00010003 { get; set; }
        public string GRID1_nFirstRecordOnPage_00010003 { get; set; }
        public string GRID1_nEOF_00010003 { get; set; }
        public string nRC_Grid1_00020003 { get; set; }
        public string Grid1ContainerData_00020003 { get; set; }
        public string GRID1_nFirstRecordOnPage_00020003 { get; set; }
        public string GRID1_nEOF_00020003 { get; set; }
        public string nRC_Grid1_00030003 { get; set; }
        public string Grid1ContainerData_00030003 { get; set; }
        public string GRID1_nFirstRecordOnPage_00030003 { get; set; }
        public string GRID1_nEOF_00030003 { get; set; }
        public string nRC_Grid2_0003 { get; set; }
        public string Grid2ContainerData_0003 { get; set; }
        public string nRC_Grid1_00010004 { get; set; }
        public string Grid1ContainerData_00010004 { get; set; }
        public string GRID1_nFirstRecordOnPage_00010004 { get; set; }
        public string GRID1_nEOF_00010004 { get; set; }
        public string nRC_Grid1_00020004 { get; set; }
        public string Grid1ContainerData_00020004 { get; set; }
        public string GRID1_nFirstRecordOnPage_00020004 { get; set; }
        public string GRID1_nEOF_00020004 { get; set; }
        public string nRC_Grid2_0004 { get; set; }
        public string Grid2ContainerData_0004 { get; set; }
        public string nRC_Grid1_00010005 { get; set; }
        public string Grid1ContainerData_00010005 { get; set; }
        public string GRID1_nFirstRecordOnPage_00010005 { get; set; }
        public string GRID1_nEOF_00010005 { get; set; }
        public string nRC_Grid1_00020005 { get; set; }
        public string Grid1ContainerData_00020005 { get; set; }
        public string GRID1_nFirstRecordOnPage_00020005 { get; set; }
        public string GRID1_nEOF_00020005 { get; set; }
        public string nRC_Grid1_00030005 { get; set; }
        public string Grid1ContainerData_00030005 { get; set; }
        public string GRID1_nFirstRecordOnPage_00030005 { get; set; }
        public string GRID1_nEOF_00030005 { get; set; }
        public string nRC_Grid1_00040005 { get; set; }
        public string Grid1ContainerData_00040005 { get; set; }
        public string GRID1_nFirstRecordOnPage_00040005 { get; set; }
        public string GRID1_nEOF_00040005 { get; set; }
        public string nRC_Grid1_00050005 { get; set; }
        public string Grid1ContainerData_00050005 { get; set; }
        public string GRID1_nFirstRecordOnPage_00050005 { get; set; }
        public string GRID1_nEOF_00050005 { get; set; }
        public string nRC_Grid1_00060005 { get; set; }
        public string Grid1ContainerData_00060005 { get; set; }
        public string GRID1_nFirstRecordOnPage_00060005 { get; set; }
        public string GRID1_nEOF_00060005 { get; set; }
        public string nRC_Grid2_0005 { get; set; }
        public string Grid2ContainerData_0005 { get; set; }
        public string nRC_Grid1_00010006 { get; set; }
        public string Grid1ContainerData_00010006 { get; set; }
        public string GRID1_nFirstRecordOnPage_00010006 { get; set; }
        public string GRID1_nEOF_00010006 { get; set; }
        public string nRC_Grid1_00020006 { get; set; }
        public string Grid1ContainerData_00020006 { get; set; }
        public string GRID1_nFirstRecordOnPage_00020006 { get; set; }
        public string GRID1_nEOF_00020006 { get; set; }
        public string nRC_Grid1_00030006 { get; set; }
        public string Grid1ContainerData_00030006 { get; set; }
        public string GRID1_nFirstRecordOnPage_00030006 { get; set; }
        public string GRID1_nEOF_00030006 { get; set; }
        public string nRC_Grid2_0006 { get; set; }
        public string Grid2ContainerData_0006 { get; set; }
        public string nRC_Grid1_00010007 { get; set; }
        public string Grid1ContainerData_00010007 { get; set; }
        public string GRID1_nFirstRecordOnPage_00010007 { get; set; }
        public string GRID1_nEOF_00010007 { get; set; }
        public string nRC_Grid2_0007 { get; set; }
        public string Grid2ContainerData_0007 { get; set; }
        public string nRC_Grid2_0008 { get; set; }
        public string Grid2ContainerData_0008 { get; set; }
        public string Grid3ContainerData { get; set; }
        public List<VTREENODECOLLECTIONDATAMPAGE> vTREENODECOLLECTIONDATA_MPAGE { get; set; }
        public VSELECTEDTREENODEMPAGE vSELECTEDTREENODE_MPAGE { get; set; }
        public string TREEVIEW1_MPAGE_Parenticon { get; set; }
        public string TREEVIEW1_MPAGE_Parentselectedicon { get; set; }
        public string TREEVIEW1_MPAGE_Leaficon { get; set; }
        public string TREEVIEW1_MPAGE_Leafselectedicon { get; set; }
        public List<AcdAlunonotasparciaisSdt> Acd_alunonotasparciais_sdt { get; set; }
        public string nRC_Grid3 { get; set; }
        public string GX_FocusControl { get; set; }
        public string GX_AJAX_KEY { get; set; }
        public string AJAX_SECURITY_TOKEN { get; set; }
        public GXCMPOBJS GX_CMP_OBJS { get; set; }
        public string sCallerURL { get; set; }
        public string GX_RES_PROVIDER { get; set; }
        public string GX_THEME { get; set; }
    }

}
