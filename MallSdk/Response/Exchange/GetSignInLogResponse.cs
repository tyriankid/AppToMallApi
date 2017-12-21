using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetSignInLogResponse : MallResponse
    {
        public List<SignInLogRespone> List { get; set; }
    }


    public class SignInLogRespone : MallResponse
    {
        /// <summary>
        /// 签到记录ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public string GoodsTypeName { get; set; }
        /// <summary>
        /// 奖励数量
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 累计奖励数量
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 连续签到天数
        /// </summary>
        public int SeriesDays { get; set; }
        /// <summary>
        /// 本月签到数
        /// </summary>
        public int MonthDays { get; set; }
        /// <summary>
        /// 累计签到数
        /// </summary>
        public int TotalDays { get; set; }
        /// <summary>
        /// 签到时间
        /// </summary>
        public DateTime LogTime { get; set; }
    }

}
