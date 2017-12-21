using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    [MallRoute("/OnLine/ModifyLeaguerInfo")]
    public class ModifyLeaguerInfoRequest : BaseRequest, IMallRequest<ModifyLeaguerInfoResponse>
    {
        /// <summary>
        /// 会员姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 会员生日
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// 会员性别
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// ID
        /// </summary>
        public Guid LeaguerID { get; set; }
    }
}
