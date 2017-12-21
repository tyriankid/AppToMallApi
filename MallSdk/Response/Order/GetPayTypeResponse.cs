using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 订单的可用支付方式
    /// </summary>
    public class GetPayTypeResponse : MallResponse
    {
        List<PayTypeListItemResponse> rows { get; set; }


    }
}
