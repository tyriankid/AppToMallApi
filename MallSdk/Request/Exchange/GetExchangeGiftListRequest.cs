using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GetExchangeGiftListOnLine")]
    /// <summary>
    /// 获取礼品详情
    /// </summary>
    public class GetExchangeGiftListRequest : BaseRequest, IMallRequest<GetExchangeGiftListResponse>
    {
        /// <summary>
        /// 每页条数
        /// </summary>
        public int? PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int? PageIndex { get; set; }
        /// <summary>
        /// 礼品分类
        /// </summary>
        public string GiftClass { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public decimal? Points { get; set; }
        /// <summary>
        /// 彩票
        /// </summary>
        public decimal? LotteryTicket { get; set; }
        /// <summary>
        /// 代币
        /// </summary>
        public decimal? Coin { get; set; }

        /// <summary>
        /// 根据推荐升序（否为降序,空不排序）
        /// </summary>
        public string IsSortAsc { get; set; }
        /// <summary>
        /// 根据积分升序（否为降序,空不排序）
        /// </summary>
        public string IsPointsAsc { get; set; }
        /// <summary>
        /// 根据彩票升序（否为降序,空不排序）
        /// </summary>
        public string IsLotteryTicketAsc { get; set; }
        /// <summary>
        /// 根据代币升序（否为降序,空不排序）
        /// </summary>
        public string IsCoinAsc { get; set; }
        /// <summary>
        /// 根据创建时间升序（否为降序,空不排序）
        /// </summary>
        public string IsTimeAsc { get; set; }
    }
}
