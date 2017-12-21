using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetActivityLogsResponse : MallResponse
    {
        public List<ActivityLogsDetailsOnLineResponse> List { get; set; }
    }

    public class ActivityLogsDetailsOnLineResponse : MallResponse
    {
        /// <summary>
        /// GUID
        /// </summary>
        public string ID { get; set; }

        public string ActivityItemID { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// 会员名
        /// </summary>
        public string LeaguerName
        {
            get;
            set;
        }
        /// <summary>
        /// 奖项数量
        /// </summary>
        public int PrizeNumber { get; set; }
        /// <summary>
        /// 中奖项名
        /// </summary>
        public string PrizeLevelName { get; set; }
        /// <summary>
        /// 中奖项别名
        /// </summary>
        public string PrizeAliasName { get; set; }
        /// <summary>
        /// 奖品名
        /// </summary>
        public string PrizeGoodsName { get; set; }
        /// <summary>
        /// 奖品数量
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// 是否已领取
        /// </summary>
        public bool IsReceived { get; set; }
        /// <summary>
        /// 领取时间
        /// </summary>
        public DateTime? ReceivedTime
        {
            get;
            set;
        }
        /// <summary>
        /// 领取对应订单号
        /// </summary>
    
        public string OrderNumber { get; set; }
        /// <summary>
        /// 抽奖时间
        /// </summary>
        public DateTime LogTime
        {
            get;
            set;
        }
    }
}
