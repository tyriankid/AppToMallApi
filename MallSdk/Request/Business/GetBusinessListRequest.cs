using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 获取门店列表
    /// </summary>
    [MallRoute("/OnLine/GetBusinessList")]
    public class GetBusinessListRequest : BaseRequest, IMallRequest<BusinessListResponse>
    {
      
    }
}
