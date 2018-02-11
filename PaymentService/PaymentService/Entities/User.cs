using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace Entities
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string UserName { set; get; }

        [DataMember]
        public string Password { set; get; }
    }
}