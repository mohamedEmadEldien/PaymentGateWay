using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace Entities
{
  public  class TransactionResponce
    {
        public string ResponseCode { set; get; }
        public string message { set; get; }
        public string ApprovalCode { set; get; }
       
        public string DateTime { set; get; }
    }
}
