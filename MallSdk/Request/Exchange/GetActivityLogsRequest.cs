using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetActivitylogsOnLine")]
    /// <summary>
    /// 抽奖记录列表
    /// </summary>
    public class GetActivityLogsRequest : BaseRequest, IMallRequest<GetActivityLogsResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public string ActivityID { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
        /// <summary>
        /// 是否中奖
        /// </summary>
        public bool? IsWinner { get; set; }
        /// <summary>
        /// 活动类型
        /// </summary>
        public int? ActivityType { get; set; }
        /// <summary>
        /// 页条数
        /// </summary>
        public int? PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int? PageIndex { get; set; }

    }
}
