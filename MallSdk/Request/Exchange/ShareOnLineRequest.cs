using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 分享
    /// </summary>
    public class ShareOnLineRequest : BaseRequest, IMallRequest<ShareOnLineResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

        /// <summary>
        /// 分享类型
        /// </summary>
        public int ShareType { get; set; }
    }
}
