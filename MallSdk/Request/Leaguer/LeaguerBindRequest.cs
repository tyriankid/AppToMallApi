using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    public class LeaguerBindRequest : BaseRequest, IMallRequest<LeaguerBindResponse>
    {
        public string WeChatID { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
    }
}
