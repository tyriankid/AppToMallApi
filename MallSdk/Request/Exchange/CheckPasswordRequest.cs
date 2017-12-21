using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/CheckPassword")]
    public class CheckPasswordRequest : BaseRequest, IMallRequest<MallResponse> 
    {
        public string LeaguerId { get; set; }
        public string Password { get; set; }
    }
}
