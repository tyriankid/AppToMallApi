using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetOrderPageList")]
    public class GetOrderPageListRequest : BaseRequest, IMallRequest<GetOrderListResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

        /// <summary>
        /// 页条数
        /// </summary>
        public int? PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int? PageIndex { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public int? PayState { get; set; }
        /// <summary>
        /// 物流状态
        /// </summary>
        public int? LogisticsState { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNum { get; set; }
        /// <summary>
        /// 会员名或卡号
        /// </summary>
        public string LgNammeOrCode { get; set; }
        /// <summary>
        /// 从记录时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 至记录时间
        /// </summary>
        public DateTime? EndTime { get; set; }

    }
}
