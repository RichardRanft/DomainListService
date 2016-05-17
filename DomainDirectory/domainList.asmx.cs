using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DomainDirectory
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://DomainDirectory/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class DomainListService : System.Web.Services.WebService
    {
        [WebMethod]
        public String GetDomainDirectory()
        {
            String DomainDictionary = "";
            // load Domain name/path dictionary from file
            using (StreamReader sr = new StreamReader(Server.MapPath("domainList.txt")))
            {
                String line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line.Length < 1)
                        continue;
                    DomainDictionary += line + ";";
                }
            }
            return DomainDictionary;
        }
    }
}