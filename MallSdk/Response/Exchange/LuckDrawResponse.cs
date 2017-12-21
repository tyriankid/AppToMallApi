using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class LuckDrawResponse : MallResponse
    {
        /// <summary>
        /// 是否中奖
        /// </summary>
        public bool IsWinning
        {
            get;
            set;
        }
        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActivityName
        {
            get;
            set;
        } 
        /// <summary>
        /// 抽奖记录ID
        /// </summary>
        public string LuckDrawLogID
        {
            get;
            set;
        }
        /// <summary>
        /// 奖项ID
        /// </summary>
        public string LuckDrawActivityItemID
        {
            get;
            set;
        }
        /// <summary>
        /// 奖项名
        /// </summary>
        public string PrizeName
        {
            get;
            set;
        }
        /// <summary>
        /// 奖项别名
        /// </summary>
        public string PrizeAlias
        {
            get;
            set;
        }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodBaseID
        {
            get;
            set;
        }
        /// <summary>
        /// 商品名
        /// </summary>
        public string GoodName
        {
            get;
            set;
        }
        /// <summary>
        /// 奖品数量
        /// </summary>
        public decimal GoodsAmount
        {
            get;
            set;
        }
    }
}
