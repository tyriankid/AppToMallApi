using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetActivityDetailsOnLine")]
    /// <summary>
    /// 活动明细
    /// </summary>
    public class GetActivityDetailsRequest : BaseRequest, IMallRequest<GetActivityDetailsResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public string ID { get; set; }

    }
}
