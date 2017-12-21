using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 线上根据Id获取会员收货地址信息
    /// </summary>
    public class GetDefaultReceiveAddressRequest : BaseRequest, IMallRequest<ReceiveAddressDetailsResponse>
    {
        public string LgBaseId { get; set; }
    }
}
