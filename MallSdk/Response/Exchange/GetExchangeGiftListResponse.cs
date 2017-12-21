using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetExchangeGiftListResponse : MallResponse
    {
        public List<ExchangeGiftItemResponse> List { get; set; }
    }

    public class ExchangeGiftItemResponse : MallResponse
    {
        /// <summary>
        /// 礼品ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsBaseID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodName { get; set; }
        /// <summary>
        /// 推荐顺序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 小图
        /// </summary>
        public string S_Photo { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public decimal ExchangeValuePrice1 { get; set; }
        /// <summary>
        /// 彩票
        /// </summary>

        public decimal ExchangeValuePrice2 { get; set; }
        /// <summary>
        /// 代币
        /// </summary>

        public decimal ExchangeValuePrice3 { get; set; }

        /// <summary>
        /// 金币
        /// </summary>

        public decimal ExchangeValuePrice4 { get; set; }

    }
}
