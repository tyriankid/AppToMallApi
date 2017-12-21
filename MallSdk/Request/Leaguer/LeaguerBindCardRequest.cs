using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 会员邦卡
    /// </summary>
    [MallRoute("/OnLine/LeaguerBindCardValidate")]
    public class LeaguerBindCardRequest : BaseRequest, IMallRequest<LeaguerBindCardResponse>
    {
        /// <summary>
        /// 会员号码
        /// </summary>
        public string LeaguerCode { get; set; }
        /// <summary>
        /// 会员密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        public string WeChatID { get; set; }
    }
    /// <summary>
    /// 会员邦卡
    /// </summary>
    [MallRoute("/OnLine/v1.2/LeaguerBindCard")]
    public class DTOLeaguerBindCardVer1_2 : BaseRequest, IMallRequest<LeaguerBindCardResponse>
    {
        /// <summary>
        /// 会员号码
        /// </summary>
        public string LeaguerCode { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }
    }
}
