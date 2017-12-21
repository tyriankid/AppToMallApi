using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 商品列表,查不到表示过期或删除了
    /// </summary>
    public class GoodsListResponse : MallResponse
    {
        public List<GoodsItem> list { get; set; }
    }
    public class GoodsItem
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        public string BussinessID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }
        /// <summary>
        /// 商品售价(结算价格)
        /// </summary>
        public decimal GoodsPrice { get; set; }
        /// <summary>
        /// 商品促销价
        /// </summary>
        public decimal? PromoPrice { get; set; }
        /// <summary>
        /// 商品促销原因
        /// </summary>
        public string PromoReason { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        public int GoodsType { get; set; }
        /// <summary>
        /// 扩展商品
        /// </summary>
        public string ExtendGoods { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string GoodsCode
        {
            get;
            set;
        }

        /// <summary>
        /// 商品描述
        /// </summary>

        public string Summery { get; set; }

        #region 商品展示
        /// <summary>
        /// 礼品简介
        /// </summary>
        public string Abstract { get; set; }

        /// <summary>
        /// 小图
        /// </summary>
        public string S_Photo
        {
            get;
            set;
        }
        #endregion

    }
}
