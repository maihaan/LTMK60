using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSPTB2
{
    /// <summary>
    /// Summary description for MyWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWS : System.Web.Services.WebService
    {
        [WebMethod]
        public String GiaiPhuongTrinhBac2(float a, float b, float c)
        {
            if (a == 0)
                return "PT có nghiệm là x = " + (-c / b).ToString();
            else
            {
                float delta = b * b - 4 * a * c;
                if (delta < 0)
                    return "Phương trình vô nghiệm";
                else if (delta == 0)
                    return "Phương trình có nghiệm kép x1 = x2 = " + (-b / 2 * a).ToString();
                else
                    return "Phương trình có 2 nghiệm phân biệt: \r\n x1 = "
                        + (-b + Math.Sqrt(delta)) / 2 * a + "\r\n x2 = "
                        + (-b - Math.Sqrt(delta)) / 2 * a;
            }
        }
        
    }
}
