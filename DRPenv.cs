 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRPmodifierWeb
{
    public class DRPenv
    {
        public string FILENAMETEXTBOX { get; set; }
        public string JOINSECRETTEXTBOX { get; set; }
        public string PARTYIDTEXTBOX { get; set; }
        public string SMALLIMAGEKEYTEXTBOX { get; set; }
        public string LARGEIMAGEKEYTEXTBOX { get; set; }
        public string SMALLIMAGETEXTBOX { get; set; }
        public string ENDTIMEBOX { get; set; }
        public string STATETEXTBOX { get; set; }
        public string CLIENTIDTEXTBOX { get; set; }
        public string LARGEIMAGETEXTBOX { get; set; }
        public string DETAILSTEXTBOX { get; set; }
        public string Id { get; set; }

        public static string ConvertToFile(DRPenv env)
        {
            //bruh
            string file = @"FILENAMETEXTBOX=" + env.FILENAMETEXTBOX + "\nJOINSECRETTEXTBOX=" + env.JOINSECRETTEXTBOX + "\nPARTYIDTEXTBOX=" + env.PARTYIDTEXTBOX +
                "\nSMALLIMAGEKEYTEXTBOX=" + env.SMALLIMAGEKEYTEXTBOX + "\nLARGEIMAGEKEYTEXTBOX=" + env.LARGEIMAGEKEYTEXTBOX + "\nSMALLIMAGETEXTBOX=" + env.SMALLIMAGETEXTBOX +
                "\nENDTIMEBOX=" + env.ENDTIMEBOX + "\nSTATETEXTBOX=" + env.STATETEXTBOX + "\nCLIENTIDTEXTBOX=" + env.CLIENTIDTEXTBOX + "\nLARGEIMAGETEXTBOX=" +
                env.LARGEIMAGETEXTBOX + "\nDETAILSTEXTBOX=" + env.DETAILSTEXTBOX;
            return file;
        }
    }
}
