using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class LeaguerApplyResponse : MallResponse
    {
        /// <summary>
        /// 会员ID（验证后才返回LeaguerID）
        /// </summary>
        public string LeaguerID { get; set; }

        /// <summary>
        /// 会员号
        /// </summary>
        public string LeaguerCode { get; set; }
    }
}
