using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{    
    public class NewGetLgPagTitAndDetailsResponse : MallResponse
    {
        public NewGetLgPagTitAndDetailsResponse()
        {
            LgPagTitDetails = new List<LgPackageTicketLogResponse>();
        }

        /// <summary>
        /// 会员套票和套票详情
        /// </summary>
        public List<LgPackageTicketLogResponse> LgPagTitDetails { get; set; }

    }

    public class LgPackageTicketLogResponse
    {
        public LgPackageTicketLogResponse()
        {
            DetailsList = new List<LgPagTitDetailsResponse>();
        }
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 票码ID
        /// </summary>
        public string TicketID { get; set; }
        /// <summary>
        /// 套票名称
        /// </summary>
        public string TicketName { get; set; }

        /// <summary>
        /// 过期时间(有玩:核销过期时间/没玩:过期时间)
        /// </summary>
        public DateTime PastDueTime { get; set; }

        /// <summary>
        /// 扣费模式：0扣值;1:计时
        /// </summary>
        public int ChargeMode { get; set; }
        /// <summary>
        /// 套票次数详情列表
        /// </summary>
        public List<LgPagTitDetailsResponse> DetailsList { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime BuyTime { get; set; }

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

    /// <summary>
    /// 套票次数详情
    /// </summary>
    public class LgPagTitDetailsResponse
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        public int RemainTimes { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        public int AllTimes { get; set; }

        /// <summary>
        /// 已使用次数
        /// </summary>
        public int UseTimes { get; set; }

        /// <summary>
        /// 计时模式说明,如果套票是计时模式时才有值
        /// </summary>
        public string ByTimeSummary { get; set; }
    }
}
