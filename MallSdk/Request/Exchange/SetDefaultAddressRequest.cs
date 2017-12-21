using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/SetDefaultAddressOnLine")]
    /// <summary>
    /// 设置默认收货地址信息
    /// </summary>
    public class SetDefaultAddressRequest : BaseRequest, IMallRequest<MallResponse>
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }  
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LgBaseId { get; set; }
    }
}
