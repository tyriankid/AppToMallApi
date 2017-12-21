using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/DTOChannelPay")]
    public class SchemeChannelPayRequest : BaseRequest, IMallRequest<SchemeChannelPayResponse>
    {
        public string PortID { get; set; }

        /// <summary>
        /// 方案使用记录ID
        /// </summary>
        public string SchemeUsedLogID { get; set; }
        /// <summary>
        /// 投币记录ID
        /// </summary>
        public string MachineCoinInLogID { get; set; }

        public string Summary { get; set; }
    }
}
