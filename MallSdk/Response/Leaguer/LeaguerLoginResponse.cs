using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class LeaguerLoginResponse : MallResponse
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeagueID { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }
    }
}
