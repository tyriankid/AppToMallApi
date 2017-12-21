using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetActivityLogsDetailsOnLine")]
    /// <summary>
    /// 抽奖记录明细
    /// </summary>
    public class GetActivityLogsDetailsRequest : BaseRequest, IMallRequest<ActivityLogsDetailsOnLineResponse>
    {
        /// <summary>
        /// 活动日志ID
        /// </summary>
        public string ID { get; set; }

    }
}
