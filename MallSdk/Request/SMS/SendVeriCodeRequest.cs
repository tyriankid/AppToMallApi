using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/SendJoinVeriCode")]
    public class SendVeriCodeRequest : BaseRequest, IMallRequest<SendVeriCodeResponse>
    {

        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }
    
    }
}
