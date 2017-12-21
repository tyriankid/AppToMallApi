using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/Online/ScanCode/")]
    public class ScanCodeRequest : BaseRequest, IMallRequest<ScanCodeResponse>
   {
       /// <summary>
       /// 会员ID
       /// </summary>
       public string LeaguerID { get; set; }
       /// <summary>
       /// Encode二维码
       /// </summary>
       public string Encode { get; set; }
   }
}
