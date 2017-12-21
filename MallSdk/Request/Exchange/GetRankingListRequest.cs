using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
     /// <summary>
    /// 得到会员签到排行榜
    /// </summary>
    [MallRoute("/OnLine/GetRankingList")]
    public class GetRankingListRequest : BaseRequest, IMallRequest<GetRankingListResponse>
    {

    }
    
}
