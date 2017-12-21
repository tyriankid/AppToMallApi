using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetExchangeOrderDetailsOnLine")]
    /// <summary>
    /// 订单明细
    /// </summary>
    public class GetExchangeOrderDetailsRequest : BaseRequest, IMallRequest<GetExchangeOrderDetailsResponse>
    {
        /// <summary>
        /// 订单号码
        /// </summary>
        public string ID { get; set; }

    }
}
