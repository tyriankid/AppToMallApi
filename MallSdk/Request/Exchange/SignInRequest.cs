using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 签到
    /// </summary>
    [MallRoute("/OnLine/SignIn")]
    public class SignInRequest : BaseRequest, IMallRequest<SignInResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
    }
}
