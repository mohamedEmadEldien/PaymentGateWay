using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
   public class UserData:BaseData
    {
        public bool validatUser(User user) {
            try
            {
                //add default user to validate user 
                string defaultUserName = "Mohamed";
                string defaultPassword = "password";
                if (user.UserName == defaultUserName && user.Password == defaultPassword)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex) {
                //log errors 
                return false;
            }
        }
    }
}
