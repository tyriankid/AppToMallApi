using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetMonthSignInLogResponse : MallResponse
    {
        /// <summary>
        /// 当月签到日期
        /// </summary>
        public string DaysStr { get; set; }
        /// <summary>
        /// 今天是否已签到
        /// </summary>
        public bool IsSignInToday { get; set; }
    }
}
