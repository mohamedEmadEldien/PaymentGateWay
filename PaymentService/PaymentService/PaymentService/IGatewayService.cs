using Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace PaymentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGatewayService" in both code and config file together.
    [ServiceContract]
    public interface IGatewayService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GenerateEncryptionKey")]
        string GenerateEncryptionKey(User user);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Payment")]
        TransactionResponce payment(Transaction transaction);

    }
}
