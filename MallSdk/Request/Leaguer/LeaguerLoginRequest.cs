using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    public class LeaguerLoginRequest : BaseRequest, IMallRequest<LeaguerLoginResponse>
    {
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string LeaguerCode { get; set; }

        /// <summary>
        /// 会员密码
        /// </summary>
        public string LeaguerPassword { get; set; }

    }
}
