using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetGiftDetailsResponse : MallResponse
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
        /// 所属礼品分类
        /// </summary>
        public string GiftClass { get; set; }

        /// <summary>
        /// 所属礼品分类
        /// </summary>
        public string GiftClassName { get; set; }

        /// <summary>
        /// 礼品简介
        /// </summary>
        public string Abstract { get; set; }

        /// <summary>
        /// 礼品详情
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// 小图
        /// </summary>
        public string S_Photo
        {
            get;
            set;
        }
        /// <summary>
        /// 中图1
        /// </summary>
        public string M_Photo_1
        {
            get;
            set;
        }
        /// <summary>
        /// 中图2
        /// </summary>
        public string M_Photo_2
        {
            get;
            set;
        }
        /// <summary>
        /// 中图3
        /// </summary>
        public string M_Photo_3
        {
            get;
            set;
        }
        /// <summary>
        /// 大图
        /// </summary>
        public string L_Photo
        {
            get;
            set;
        }
        public int? Sort
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodName { get; set; }
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
        /// 库存
        /// </summary>

        public decimal Stock { get; set; }
        /// <summary>
        /// 是否实物商品
        /// </summary>
        public bool? IsReal { get; set; }
    }
}
