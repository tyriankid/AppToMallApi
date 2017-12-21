using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 订单明细
    /// </summary>
    [MallRoute("/OnLine/GetOrderDetails")]
    public class GetOrderDetailsRequest : BaseRequest, IMallRequest<GetOrderDetailsResponse>
    {
        /// <summary>
        /// 订单号码
        /// </summary>
        public string ID { get; set; }

    }
}
