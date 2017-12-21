using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 订单支付加订单完成
    /// </summary>
    public class OrderPayAndCompletedRequest : BaseRequest, IMallRequest<MallResponse>
    { 
        
        ///// <summary>
        ///// 商户ID
        ///// </summary>
        //public string BussinessID { get; set; }
        /// <summary>
        /// 订单号码
        /// </summary>
        public string TPOrderNo { get; set; }

    }
}
