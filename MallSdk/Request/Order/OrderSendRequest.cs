using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 订单发货
    /// </summary>
    public class OrderSendRequest : BaseRequest, IMallRequest<MallResponse>
    { 
        /// <summary>
        /// 订单号码
        /// </summary>
        public string TPOrderNo { get; set; }

    }
}
