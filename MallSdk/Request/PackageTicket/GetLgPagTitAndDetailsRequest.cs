using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/Online/DTOGetLgPagTitAndDetails")]
    public class GetLgPagTitAndDetailsRequest : BaseRequest, IMallRequest<GetLgPagTitAndDetailsResponse>
    {
        public string LeaguerID { get; set; }
    }
}
