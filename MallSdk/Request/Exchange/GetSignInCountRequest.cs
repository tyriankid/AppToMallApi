using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 得到会员签到成就
    /// </summary>
    [MallRoute("/OnLine/GetSignInCount")]
    public class GetSignInCountRequest : BaseRequest, IMallRequest<SignInLogRespone>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

    }
}
