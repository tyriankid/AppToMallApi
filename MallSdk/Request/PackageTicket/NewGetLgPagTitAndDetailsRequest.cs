using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/Online/GetLgPagTitDetails")]
    public class NewGetLgPagTitAndDetailsRequest : BaseRequest, IMallRequest<NewGetLgPagTitAndDetailsResponse>
    {
        public string LeaguerID { get; set; }
    }
}
