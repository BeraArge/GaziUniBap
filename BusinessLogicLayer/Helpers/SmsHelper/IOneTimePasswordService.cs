using DataTransferObject.SmsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Helpers.SmsHelper
{
    public interface IOneTimePasswordService
    {
        public Task<SendOtpResponse> SendOtp(string message, List<string> to);
    }
}
