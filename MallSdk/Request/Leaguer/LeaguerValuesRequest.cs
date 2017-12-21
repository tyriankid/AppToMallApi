using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    [MallRoute("/OnLine/GetLeaguerValues")]
    public class LeaguerValuesRequest : BaseRequest, IMallRequest<LeaguerValuesResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
        /// <summary>
        /// 储值类型(0所有，1预存款，3积分...)
        /// </summary>
        public int ValueCode { get; set; }
        /// <summary>
        /// 支付方式ID
        /// </summary>
        public string PayID { get; set; }
    }
}
