using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetExchangeOrderListOnLine")]
    /// <summary>
    /// 取订单（最近20条）
    /// </summary>
    public class GetExchangeOrderListRequest : BaseRequest, IMallRequest<GetExchangeOrderListResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
        /// <summary>
        /// 条数
        /// </summary>
        public int? TakeCount { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public int? PayState { get; set; }
        /// <summary>
        /// 支付方式（积分、彩票）
        /// </summary>
        public int? ExchangeValueType { get; set; }

    }
}
