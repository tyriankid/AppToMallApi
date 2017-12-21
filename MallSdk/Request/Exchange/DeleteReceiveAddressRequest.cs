using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/DeleteReceiveAddressOnLine")]
    /// <summary>
    /// 线上删除会员收货地址信息
    /// </summary>
    public class DeleteReceiveAddressRequest : BaseRequest, IMallRequest<MallResponse>
    {
        public string Id { get; set; }
    }
}
