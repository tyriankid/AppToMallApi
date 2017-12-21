using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    [MallRoute("/OnLine/GetLeaguerInfo")]
    public class LeaguerInfoRequest : BaseRequest, IMallRequest<LeaguerInfoResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public Guid? LeaguerID { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }
    }
}
