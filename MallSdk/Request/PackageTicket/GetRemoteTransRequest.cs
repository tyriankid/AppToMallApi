using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/Online/GetRemoteTrans")]
    public class GetRemoteTransRequest : BaseRequest, IMallRequest<GetRemoteTransResponse>
    {
        /// <summary>
        /// TransID
        /// </summary>
        public string StateID { get; set; }
        ////微信号
        //public string WechatID { get; set; }
        /////// <summary>
        /////// 会员ID
        /////// </summary>
        ////public string LeaguerID { get; set; }
        //public string PhoneNum { get; set; }
        //public string Password { get; set; }
    }
}
