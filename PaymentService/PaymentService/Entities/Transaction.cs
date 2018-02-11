using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public string ProcessingCode { set; get; }

        [DataMember]
        public string SystemTraceNr { set; get; }

        [DataMember]
        public string FunctionCode { set; get; }

        [DataMember]
        [StringLength(16, MinimumLength = 16, ErrorMessage = @"CardNo length should be equal 16 digit.")]
        public string CardNo { set; get; }

        [DataMember]
        public string CardHolder { set; get; }

        [DataMember]
        public string AmountTrxn { set; get; }

        [DataMember]
        public string CurrencyCode { set; get; }

    }
}