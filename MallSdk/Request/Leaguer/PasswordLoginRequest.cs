using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 线上手机号码跟密码登录
    /// </summary>
    public class PasswordLoginRequest : BaseRequest, IMallRequest<PasswordLoginResponse>
    {
        //微信号
        public string WechatID { get; set; }
        public string PhoneNum { get; set; }
        public string Password { get; set; }
    }
}
