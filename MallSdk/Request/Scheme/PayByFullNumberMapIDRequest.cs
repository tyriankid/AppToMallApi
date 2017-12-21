using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/DTOPayByFullNumberMapID")]
    public class PayByFullNumberMapIDRequest : BaseRequest, IMallRequest<PayByFullNumberMapIDResponse>
    {
        public Guid FullNumberMapID { get; set; }
        public Guid PortID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 交易ID
        /// </summary>
        public string ChargingId { get; set; }
    }
}
