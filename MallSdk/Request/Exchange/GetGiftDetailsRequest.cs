using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetGiftDetailsOnLine")]
    /// <summary>
    /// 获取礼品详情
    /// </summary>
    public class GetGiftDetailsRequest : BaseRequest, IMallRequest<GetGiftDetailsResponse>
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string ID { get; set; }
    }
}
