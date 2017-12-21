using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 获取分享设置
    /// </summary>
    public class GetShareSetOnlineRequest : BaseRequest, IMallRequest<GetShareSetOnlineResponse>
    {
        public int ShareType { get; set; }
    }
}
