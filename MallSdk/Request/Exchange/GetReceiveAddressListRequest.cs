using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetReceiveAddressListOnLine")]
    /// <summary>
    /// 线上接口获取会员地址信息
    /// </summary>
    public class GetReceiveAddressListRequest : BaseRequest, IMallRequest<GetReceiveAddressListResponse>
    { 
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LgBaseId { get; set; }
        /// <summary>
        /// 是否只查默认地址
        /// </summary>
        public bool? IsDefault { get; set; }
    }
}
