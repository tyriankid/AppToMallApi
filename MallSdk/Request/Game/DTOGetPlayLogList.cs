using System;
using System.Collections.Generic;
using System.Linq;
using System;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 获取会员游玩记录
    /// </summary>
    [MallRoute("/OnLine/v1.2/GetPlayLogList")]
    public class DTOGetPlayLogListRequst : BaseRequest, IMallRequest<DTOGetPlayLogListResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerId { get; set; }
        /// <summary>
        /// 条数
        /// </summary>
        public int? RowCount { get; set; }
    }

    /// <summary>
    /// 获取会员游玩记录（分页）
    /// </summary>
    [MallRoute("/OnLine/v1.2/GetPlayLogListByPage")]
    public class DTOGetPlayLogListByPageRequst : BaseRequest, IMallRequest<DTOGetPlayLogListResponse>
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerId { get; set; }
        /// <summary>
        /// 记录开始时间
        /// </summary>
        public DateTime? StartLogTime { get; set; }
        /// <summary>
        /// 记录结束时间
        /// </summary>
        public DateTime? EndLogTime { get; set; }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
    }

    public class DTOGetPlayLogListResponse : MallResponse
    {
       public  List<PlayLog> List { get; set; } 
    }

    public class PlayLog
    {
        /// <summary>
        /// 游玩记录类型
        /// </summary>
        public int LogType { get; set; }
        /// <summary>
        /// 游玩记录ID
        /// </summary>
        public string PlayLogId { get; set; }
        /// <summary>
        /// 游玩记录时间
        /// </summary>
        public string LogTime { get; set; }
        /// <summary>
        /// 游玩记录时间（最后更新时间）
        /// </summary>
        public string PlayTime { get; set; }
        /// <summary>
        /// 游玩费用
        /// </summary>
        public decimal PlayCharge { get; set; }
        /// <summary>
        /// 游玩记录说明
        /// </summary>
        public string PlaySummary { get; set; }
        /// <summary>
        /// 游玩项目名称
        /// </summary>
        public string PlayMacName { get; set; }
    }
}
