using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/CancelOrder")]
    public class CancelOrderRequest : BaseRequest, IMallRequest<MallResponse>
    {

        /// <summary>
        /// 第三方订单号
        /// </summary>
        public string TPOrderNo { get; set; }
        ///// <summary>
        ///// 商户ID
        ///// </summary>
        //public string BussinessID { get; set; }

    }
}
