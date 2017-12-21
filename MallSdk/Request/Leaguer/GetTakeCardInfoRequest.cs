using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetTakeCardInfo")]
    public class GetTakeCardInfoRequest : BaseRequest, IMallRequest<GetTakeCardInfoResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
    }
}
