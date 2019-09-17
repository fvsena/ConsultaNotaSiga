using System.Text;

namespace RoboSiga.Helpers
{
    public class SigaHelper
    {
        public static string PostDataLogon(string login, string senha)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"vSIS_USUARIOID={login}&");
            sb.Append($"vSIS_USUARIOSENHA={senha}&");
            sb.Append("BTCONFIRMA=Confirmar&");
            sb.Append("GXState={\"_EventName\":\"E'EVT_CONFIRMAR'.\",\"_EventGridId\":\"\",\"_EventRowId\":\"\",\"MPW0005_CMPPGM\":\"login_top.aspx\",\"MPW0005GX_FocusControl\":\"\",\"vSAIDA\":\"\",\"vREC_SIS_USUARIOID\":\"\",\"GX_FocusControl\":\"vSIS_USUARIOID\",\"GX_AJAX_KEY\":\"99728F525D2BB33D3E647500D4202141\",\"AJAX_SECURITY_TOKEN\":\"9E2B26EA86EC4E272CF16B32BE17C9E055B68F46895B95B4B79EFDCB0B3C7630\",\"GX_CMP_OBJS\":{\"MPW0005\":\"login_top\"},\"sCallerURL\":\"\",\"GX_RES_PROVIDER\":\"GXResourceProvider.aspx\",\"GX_THEME\":\"GeneXusX\",\"_MODE\":\"\",\"Mode\":\"\",\"IsModified\":\"1\"}");
            return sb.ToString();
        }
    }
}
