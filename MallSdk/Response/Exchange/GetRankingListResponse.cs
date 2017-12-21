using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetRankingListResponse : MallResponse
    {
        public List<SignInRankingListItemResponse> List { get; set; }
    }
    public class SignInRankingListItemResponse : MallResponse
    {
        /// <summary>
        /// 会员姓名
        /// </summary>
        public string LeaguerName { get; set; }
        /// <summary>
        /// 累计天数
        /// </summary>
        public int TotalDays { get; set; }
        /// <summary>
        /// 累计奖励
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}
