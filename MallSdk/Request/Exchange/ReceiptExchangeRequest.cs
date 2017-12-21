using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/ReceiptExchangeOnLine")]
    /// <summary>
    /// 兑换单收货
    /// </summary>
    public class ReceiptExchangeRequest : BaseRequest, IMallRequest<MallResponse>
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
    }
}
