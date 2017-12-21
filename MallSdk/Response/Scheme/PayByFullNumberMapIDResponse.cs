using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{

    public class PayByFullNumberMapIDResponse : MallResponse
    {
        /// <summary>
        /// 事务ID
        /// </summary>
        public string TransID { get; set; }

        /// <summary>
        /// 状态补充说明
        /// </summary>
        public string StateMsg { get; set; }

        /// <summary>
        /// 事务状态码
        /// 需要继续询问的状态(5=建立连接,9=正在投币)
        /// 成功的状态(17=全部完成,)
        /// 错误的状态(2=未知错误,34=投币超时,66=投币取消)
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 是否成功,在IsFinish=true是才有效
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 是否已经结束,没有完成需要继续查询,如果已经完成就要看IsSuccess才能确定是否成功
        /// </summary>
        public bool IsFinish { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime Consumetime { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime FinishTime { get; set; }
        /// <summary>
        /// 方案使用记录ID
        /// </summary>
        public string SchemeUsedLogID { get; set; }
        /// <summary>
        /// 投币记录ID
        /// </summary>
        public string MachineCoinInLogID { get; set; }
    }
}
