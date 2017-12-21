using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 手机号和短信验证码（取卡主体界面中使用）
    /// </summary>
    [MallRoute("/OnLine/GetPhoneNumAndCode")]
    public class LeaguerPhoneAndValidateCodeRequest : BaseRequest, IMallRequest<LeaguerPhoneAndValidateCodeResponse>
    {
        public string LeaguerID { get; set; }
    }
}
