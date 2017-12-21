using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 线上预存款支付：预存款转账到渠道往来单位账户
    /// </summary>
    [MallRoute("/OnLine/PrepaidChangeToParnerAcount")]
    public class PrepaidChangeToParnerAcountRequest : BaseRequest, IMallRequest<MallResponse>
    { 
        /// <summary>
        /// 订单号码
        /// </summary>
        public string TPOrderNo { get; set; }

    }
}
