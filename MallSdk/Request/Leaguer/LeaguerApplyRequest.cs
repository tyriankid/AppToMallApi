using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 线上入会
    /// </summary>
    [MallRoute("/OnLine/LeaguerApply")]
    public class LeaguerApplyRequest : BaseRequest, IMallRequest<LeaguerApplyResponse>
    {

        public string WeChatID { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 性别 0女，1男，2未知
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 会员临时ID
        /// </summary>
        public string LeaguerTempID { get; set; }
    }
}
