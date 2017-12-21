using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{    
    /// <summary>
    /// 会员入会申请结果,
    /// </summary>
    public class CheckJoinVeriCodeResponse : MallResponse
    {


        /// <summary>
        /// 会员临时ID（验证前置返回LeaguerTempID）
        /// </summary>
        public string LeaguerTempID { get; set; }
    }
}
