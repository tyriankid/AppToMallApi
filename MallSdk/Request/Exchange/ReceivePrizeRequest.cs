using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/ReceivePrizeOnLine")]
    /// <summary>
    /// 领奖
    /// </summary>
    public class ReceivePrizeRequest : BaseRequest, IMallRequest<MallResponse>
    {      
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

        /// <summary>
        /// 抽奖纪录ID
        /// </summary>
        public string LuckDrawLogID { get; set; }

        /// <summary>
        /// 奖品项ID
        /// </summary>
        public string ActivityItemID { get; set; }
    }
}
