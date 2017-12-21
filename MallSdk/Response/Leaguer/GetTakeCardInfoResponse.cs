using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetTakeCardInfoResponse : MallResponse
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public DateTime? TakeCardDate { get; set; }
        /// <summary>
        /// 开卡商户
        /// </summary>
        public string OpenBusinessID { get; set; }
        /// <summary>
        /// 开卡商户名称
        /// </summary>
        public string OpenBusinessName { get; set; }
        /// <summary>
        /// 开卡商户地址
        /// </summary>
        public string OpenBusinessAddress { get; set; }

        /// <summary>
        /// 线下取卡卡押金
        /// </summary>
        public decimal CardDeposit
        {
            get;
            set;
        }
        /// <summary>
        /// 线下取卡工本费
        /// </summary>
        public decimal HandlingCharge
        {
            get;
            set;
        }
    }
}
