using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetPackageTicketByIDResponse : MallResponse
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string PromoReason { get; set; }
        public decimal? PromoPrice { get; set; }
        /// <summary>
        /// 套票项目
        /// </summary>
        public List<PackageTicketCurrMachineResponse> CurrMachine { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public string EffectivePeriod { get; set; }
        /// <summary>
        /// 核销时长
        /// </summary>
        public string WriteOffPeriod { get; set; }
        /// <summary>
        /// 每次可购买张数
        /// </summary>
        public int TicketCount { get; set; }
        /// <summary>
        /// 每张送币数
        /// </summary>
        public int CoinCount { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal GoodsPrice { get; set; }
        /// <summary>
        /// 建议售价
        /// </summary>
        public decimal SuggestSellPrice { get; set; }

        /// <summary>
        /// 周几可用
        /// </summary>
        public string StrCanUseDays { get; set; }

        /// <summary>
        /// 计时模式
        /// </summary>
        public string ByTimeSummary { get; set; }

        /// <summary>
        /// 扣费模式：0扣值;1:计时
        /// </summary>
        public int ChargeMode { get; set; }

        #region 商品展示
        /// <summary>
        /// 礼品简介
        /// </summary>
        public string Abstract { get; set; }

        /// <summary>
        /// 礼品详情
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// 小图
        /// </summary>
        public string S_Photo
        {
            get;
            set;
        }
        /// <summary>
        /// 中图1
        /// </summary>
        public string M_Photo_1
        {
            get;
            set;
        }
        /// <summary>
        /// 中图2
        /// </summary>
        public string M_Photo_2
        {
            get;
            set;
        }
        /// <summary>
        /// 中图3
        /// </summary>
        public string M_Photo_3
        {
            get;
            set;
        }
        /// <summary>
        /// 大图
        /// </summary>
        public string L_Photo
        {
            get;
            set;
        }
        #endregion

    }

    /// <summary>
    /// 套票项目
    /// </summary>
    public class PackageTicketCurrMachineResponse : MallResponse
    {
        public string ID { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        public string MachineName { get; set; }

        public string MachineType { get; set; }
        /// <summary>
        /// 全部次数
        /// </summary>
        public int AllTimes { get; set; }
        /// <summary>
        /// 使用次数
        /// </summary>
        public int UseTimes { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        public int CanUseTimes { get; set; }

        public string BindingMachineID { get; set; }

    }
}
