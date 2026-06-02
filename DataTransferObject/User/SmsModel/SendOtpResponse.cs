using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SmsModel
{
    public class SendOtpResponse
    {
        public bool Result { get; set; }

        public object Data { get; set; }
    }
}
