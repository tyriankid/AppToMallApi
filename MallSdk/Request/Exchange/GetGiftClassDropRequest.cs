using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetGiftClassDropOnLine")]
    /// <summary>
    /// 获取礼品分类
    /// </summary>
    public class GetGiftClassDropRequest : BaseRequest, IMallRequest<DropListResponse>
    {
      
    }
}
