using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/LuckDrawOnLine")]
    /// <summary>
    /// 抽奖
    /// </summary>
    public class LuckDrawRequest : BaseRequest, IMallRequest<LuckDrawResponse>
    {      
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        public string ActivityID { get; set; }
    }
}
