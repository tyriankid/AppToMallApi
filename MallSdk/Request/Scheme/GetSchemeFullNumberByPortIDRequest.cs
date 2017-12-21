using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/DTOGetSchemeFullNumberByPortID")]
    public class GetSchemeFullNumberByPortIDRequest : BaseRequest, IMallRequest<SchemeFullNumberByPortIDResponse>
    {
        public string ID { get; set; }
    }
}
