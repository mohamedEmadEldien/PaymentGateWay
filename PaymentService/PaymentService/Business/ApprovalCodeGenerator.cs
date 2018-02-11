using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //use singelton to make sure approvalcode unique
   public class ApprovalCodeGenerator
    {
        private static ApprovalCodeGenerator instance;

        private ApprovalCodeGenerator() { }
        private static long approvalcode;

        public static ApprovalCodeGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApprovalCodeGenerator();
                   approvalcode = 111111;//to be load from other source
                }
                return instance;
            }
        }
        public string Approvalcode
        {

            get { return approvalcode++.ToString().Substring(0,6); }
        }


       
    }
}
