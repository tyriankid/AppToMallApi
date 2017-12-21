using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;
using MallSdk;

namespace MallSdk
{
    /// <summary>
    /// 商户（门店）
    /// </summary>
    /// 
    public class GetBusinessRequest : BaseRequest, IMallRequest<BusinessRespone>
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        public string BisID { get; set; }
    }
}
