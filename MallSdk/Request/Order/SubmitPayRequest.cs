using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk.Request.Order
{
    /// <summary>
    /// 提交支付
    /// </summary>
    public class SubmitPayRequest : BaseRequest, IMallRequest<MallResponse>
    { 
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
        ///// <summary>
        ///// 商户ID
        ///// </summary>
        //public string BussinessID { get; set; }
        /// <summary>
        /// 订单号码
        /// </summary>
        public string TPOrderNo { get; set; }

        /// <summary>
        /// 是否为自己订单
        /// </summary>
        public bool IsOwnedOrder { get; set; } 
        /// <summary>
        /// 支付方式ID
        /// </summary>
        public string PayID { get; set; }
        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal PayMoney { get; set; }
    }
}
