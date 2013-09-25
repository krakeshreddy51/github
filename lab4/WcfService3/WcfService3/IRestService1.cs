using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestService1" in both code and config file together.
    [ServiceContract]
    public interface IRestService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,BodyStyle=WebMessageBodyStyle.Wrapped, UriTemplate = "Addition/{a}/{b}")]

        string Addition(string a,string b);
        
         [OperationContract]
         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,BodyStyle=WebMessageBodyStyle.Wrapped, UriTemplate = "Subtraction/{a}/{b}")]

        string Subtraction(string a,string b);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,BodyStyle=WebMessageBodyStyle.Wrapped, UriTemplate = "Multiplication/{a}/{b}")]

        string Multiplication(string a,string b);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,BodyStyle=WebMessageBodyStyle.Wrapped,UriTemplate = "Division/{a}/{b}")]

        string Division(string a,string b);
    }
}
