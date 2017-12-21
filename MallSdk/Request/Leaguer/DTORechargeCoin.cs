using System;
using MallSdk.Request;

namespace MallSdk
{
    [MallRoute("/OnLine/v1.2/RechargeCoin")]
    public class DTORechargeCoin : BaseRequest, IMallRequest<MallResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public Guid LeaguerId { get; set; }
        /// <summary>
        /// 代币数
        /// </summary>
        public int CoinAmount { get; set; }
    }
}
