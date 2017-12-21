using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetActivityListPageOnLine")]
    /// <summary>
    /// 活动列表
    /// </summary>
    public class GetActivityListRequest : BaseRequest, IMallRequest<GetActivityListResponse>
    {
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
