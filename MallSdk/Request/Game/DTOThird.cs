using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MallSdk;
using MallSdk.Request;

namespace MallSdk
{
    [MallRoute("/Game/Machine/ThirdConsumption")]
    public class DTOThirdConsumption : BaseRequestGame, IMallRequest<DTOThirdValidationRespone>
    {
        /// <summary>
        /// 消费类型
        /// </summary>
        public int ValueCode { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public string TransactionNo { get; set; }
    }

    [MallRoute("/Game/Machine/ThirdReturnConsumption")]
    public class DTOThirdReturnConsumption : BaseRequestGame, IMallRequest<DTOThirdValidationRespone>
    {
        /// <summary>
        /// 交易号
        /// </summary>
        public string TransactionNo { get; set; }
    }

    public class DTOThirdValidationRespone : MallResponse
    {
        /// <summary>
        /// 操作(扣费或回滚)后金额
        /// </summary>
        public decimal TargetAmount { get; set; }
        /// <summary>
        /// 交易号
        /// </summary>
        public string TransactionNo { get; set; }
    }
    
    [MallRoute("/Game/Machine/ThirdGetLeaguerStatus")]
    public class DTOThirdGetLeaguerStatus : BaseRequestGame, IMallRequest<DTOThirdLeaguerStatusRespone>
    {
    }
    public class DTOThirdLeaguerStatusRespone : MallResponse
    {
        /// <summary>
        /// 会员号
        /// </summary>
        public string LeaguerCode { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        public string LevelName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>

        public string RealName { get; set; }
        /// <summary>
        /// 会员状态
        /// </summary>

        public int LeaguerStatus { get; set; }
        
        /// <summary>
        /// 预存款
        /// </summary>
        public decimal Preraid { get; set; }
        /// <summary>
        /// 金币
        /// </summary>
        public decimal GoldCoin { get; set; }
        /// <summary>
        /// 代币
        /// </summary>
        public decimal Coin { get; set; }
    }
}
