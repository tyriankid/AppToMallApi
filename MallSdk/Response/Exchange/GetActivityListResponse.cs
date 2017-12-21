using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetActivityListResponse : MallResponse
    {
        public List<ActivityListPageOnLineDetailsResponse> List { get; set; }
    }

    public class ActivityListPageOnLineDetailsResponse
    {
        /// <summary>
        /// GUID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 活动性质（免费，积分，彩票）
        /// </summary>
        public int NatureType { get; set; }
        /// <summary>
        /// 活动性质（免费，积分，彩票）
        /// </summary>
        public string NatureTypeName { get; set; }
        /// <summary>
        /// 活动状态(新增、开始、停止)
        /// </summary>
        public int ActivityState { get; set; }
        /// <summary>
        /// 参与费用
        /// </summary>
        public decimal Cost { get; set; }
        /// <summary>
        /// 抽奖总次数
        /// </summary>
        public int LuckDrawTotal { get; set; }
        /// <summary>
        /// 当前索引
        /// </summary>
        public int QueueIndex { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime StopTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 最后更新员工
        /// </summary>
        public string LastEditMerchant { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime
        {
            get;
            set;
        }
    }
}
