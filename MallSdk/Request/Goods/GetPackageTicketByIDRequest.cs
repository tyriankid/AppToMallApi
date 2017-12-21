using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 套票商品详细
    /// </summary>
    [MallRoute("/OnLine/GetPackageTicketByID")]
    public class GetPackageTicketByIDRequest : BaseRequest, IMallRequest<GetPackageTicketByIDResponse>
    {
        public Guid ID { get; set; }

        public Guid LeaguerID { get; set; }
    }
}
