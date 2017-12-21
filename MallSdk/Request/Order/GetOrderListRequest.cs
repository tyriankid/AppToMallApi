using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 获得订单可用支付方式的请求
    /// </summary>
    [MallRoute("/OnLine/GetOrderList")]
    public class GetOrderListRequest : BaseRequest, IMallRequest<GetOrderListResponse>
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
        ///// <summary>
        ///// 商户ID
        ///// </summary>
        //public string BussinessID { get; set; }
        /// <summary>
        /// 订单号码
        /// </summary>
        //public string TPOrderNo { get; set; }
        ///// <summary>
        ///// 是否为自己订单
        ///// </summary>
        //public bool IsOwnedOrder { get; set; }
    }
}
