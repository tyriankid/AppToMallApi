using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetLgPagTitAndDetailsResponse : MallResponse
    {
        public GetLgPagTitAndDetailsResponse()
        {
            LgPagTitAndDetails = new List<LgPackageTicketBuyLogResponse>();
        }

        /// <summary>
        /// 会员套票和套票详情
        /// </summary>
        public List<LgPackageTicketBuyLogResponse> LgPagTitAndDetails { get; set; }
    }

    public class LgPackageTicketBuyLogResponse
    {
        public LgPackageTicketBuyLogResponse()
        {
            DetailsList = new List<LgPackageTicketDetailsResponse>();
        }
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// TicketId
        /// </summary>
        public string TicketId { get; set; }
        /// <summary>
        /// 套票名称
        /// </summary>
        public string PackageTicket { get; set; }

        /// <summary>
        /// 过期时间(有玩:核销过期时间/没玩:过期时间)
        /// </summary>
        public DateTime PastDueTime { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime BuyTime { get; set; }
        /// <summary>
        /// 套票次数详情列表
        /// </summary>
        public List<LgPackageTicketDetailsResponse> DetailsList { get; set; }

        
    }


    /// <summary>
    /// 套票次数详情
    /// </summary>
    public class LgPackageTicketDetailsResponse
    {
        /// <summary>
        /// 0：扣值 1：计时
        /// </summary>
        //public int ChargeMode { get; set; }
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

        
    }
}
