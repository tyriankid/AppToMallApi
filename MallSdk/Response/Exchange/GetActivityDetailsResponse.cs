using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetActivityDetailsResponse : MallResponse
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
        /// 抽奖索引
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
        /// <summary>
        /// 会员级别抽奖次数设置
        /// </summary>
        public List<LevelTimesReponse> LevelTimesObj { get; set; }
        /// <summary>
        /// 活动奖品奖项设置
        /// </summary>
        public List<PrizeInfoReponse> PrizeObj { get; set; }

    }

    public class LevelTimesReponse
    {
        /// <summary>
        /// 级别ID
        /// </summary>
        public string LevelID { get; set; }
        /// <summary>
        /// 级别名称
        /// </summary>
        public string LevelName { get; set; }
        /// <summary>
        /// 每天次数
        /// </summary>
        public int DayTimes { get; set; }
        /// <summary>
        /// 总次数
        /// </summary>
        public int TotalTimes { get; set; }
    }

    public class PrizeInfoReponse
    {
        public string ID { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public int GoodsType { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int GoodsNumber { get; set; }
        /// <summary>
        /// 奖项ID
        /// </summary>
        public int PrizeTypeID { get; set; }
        /// <summary>
        /// 奖项名
        /// </summary>
        public string PrizeTypeName { get; set; }
        /// <summary>
        /// 奖项别名
        /// </summary>
        public string PrizeAlias { get; set; }
        /// <summary>
        /// 奖项数量
        /// </summary>
        public int PrizeNumber { get; set; }

    }
}
