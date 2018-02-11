using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using Business;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using Utilities;

namespace PaymentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GatewayService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GatewayService.svc or GatewayService.svc.cs at the Solution Explorer and start debugging.
    public class GatewayService : IGatewayService
    {
       
        public string GenerateEncryptionKey(User user)
        {
            UserBusiness userBusiness = new UserBusiness();
            string key="";
            if (userBusiness.validatUser(user))
            {
                Security security = new Security();
                 key = security.GetEncryptionKey();
                
            }

            return key;
        }
      
        public TransactionResponce payment(Transaction transaction)
        {
            //some code to make payment operation
            TransactionResponce responce = new TransactionResponce();
            responce.message = "Success";
            responce.ResponseCode = ResponceCode.Ok.ToString();
            responce.ApprovalCode = ApprovalCodeGenerator.Instance.Approvalcode;
            responce.DateTime = DateTime.Now.ToString("yyyyMMddHHmm");
            return  responce;
        }


    }
}
