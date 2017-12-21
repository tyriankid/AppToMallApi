using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 得到会员签到记录
    /// </summary>
    [MallRoute("/OnLine/GetSignInLog")]
    public class GetSignInLogRequest: BaseRequest, IMallRequest<GetSignInLogResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
        /// <summary>
        /// 页条数
        /// </summary>
        public int? PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int? PageIndex { get; set; }
    }
}
