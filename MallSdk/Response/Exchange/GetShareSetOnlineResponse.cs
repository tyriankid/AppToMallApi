using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetShareSetOnlineResponse : MallResponse
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 分享类型
        /// </summary>
        public int ShareType { get; set; }
        /// <summary>
        /// 分享类型名
        /// </summary>
        public string ShareTypeName { get; set; }
        /// <summary>
        /// 商品类型(积分、彩票、虚拟商品)
        /// </summary>
        public int GoodsType { get; set; }
        /// <summary>
        /// 商品类型(积分、彩票、虚拟商品)
        /// </summary>
        public string GoodsTypeName { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public decimal Number { get; set; }
        /// <summary>
        /// 每天最多N次奖励分享
        /// </summary>
        public int MaxTimes { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public byte[] Image { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
