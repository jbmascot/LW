using Newtonsoft.Json;
using System;
using System.Web.Services;
using System.Xml;

namespace LemonWayChalenge
{
    /// <summary>
    /// Description résumée de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public long Fibonacci(long N)
        {
            if (N < 1 || N > 100)
            {
                return -1;
            }
            else if ( N == 1) 
            {
                return 1;
            }
            else
            {
                long a = 0;
                long b = 1;
                long pv;

                for (long j = 2; j <= N; j++)
                {
                    if (Int64.MaxValue - b < a) 
                    {
                        return -1;
                    }

                    pv = a + b;
                    a = b;
                    b = pv;
                }

                return b;
            }
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();
            try 
            {
                doc.LoadXml(xml);

                //Delete XmlDeclarations
                foreach (XmlNode node in doc) 
                {
                    if (node.NodeType == XmlNodeType.XmlDeclaration)
                    {
                        doc.RemoveChild(node);
                    }
                }
            }
            catch (Exception ex) 
            {
                return "Bad Xml format";
            }

            return JsonConvert.SerializeXmlNode(doc);
        }
    }
}
