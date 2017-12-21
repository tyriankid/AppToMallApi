using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/CheckJoinVeriCode")]
    public class CheckJoinVeriCodeRequest : BaseRequest, IMallRequest<CheckJoinVeriCodeResponse>
    {
        /// <summary>
        /// 会员临时ID
        /// </summary>
        public string LeaguerTempID { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string VerificationCode { get; set; }
    
    }
}
