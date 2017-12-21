using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 获取商品列表
    /// </summary>
    [MallRoute("/OnLine/v1.2/GetGoodsList")]
    public class GetGoodsListRequest : BaseRequest, IMallRequest<GoodsListResponse>
    {
        /// <summary>
        /// 商品类型ID
        /// </summary>
        public int? goodsType { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
    }
}
