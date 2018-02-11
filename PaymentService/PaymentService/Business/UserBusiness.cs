using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;

namespace Business
{
    public class UserBusiness:BusinessBase
    {
        public bool validatUser(User user) {
            Data.UserData userData = new Data.UserData();
            return userData.validatUser(user);
        }
       
    }
}
