using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetGiftLogisticsListOnLine")]
    /// <summary>
    /// 线上接口获取线上兑换物流设置
    /// </summary>
    public class GetGiftLogisticsListRequest : BaseRequest, IMallRequest<GetGiftLogisticsListResponse>
    { 
        /// <summary>
        /// 物流方式类别
        /// </summary>
        public int? LogisticsType { get; set; }
    }
}
