using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 得到会员当月签到过的日期
    /// </summary>
    [MallRoute("/OnLine/GetMonthSignInLog")]
    public class GetMonthSignInLogRequest : BaseRequest, IMallRequest<GetMonthSignInLogResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

    }
}
