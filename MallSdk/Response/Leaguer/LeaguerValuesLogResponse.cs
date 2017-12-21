using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class LeaguerValuesLogResponse : MallResponse
    {
        /// <summary>
        /// 改变记录明细
        /// </summary>
        public List<LeaguerValuesLogItem> rows { get; set; }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalCount { get; set; }
    }
    public class LeaguerValuesLogItem
    {
        /// <summary>
        /// 商户名称(积分和预存款则显示为空【总部】)
        /// </summary>
        public string BusinessName { get; set; }


        /// <summary>
        /// 储值类型名称
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 更改前值
        /// </summary>
        public virtual decimal SourceValue
        {
            get;
            set;
        }
        /// <summary>
        /// 变更数量
        /// 如果是减少请用-号
        /// </summary>
        public virtual decimal ChangeValue
        {
            get;
            set;
        }
        /// <summary>
        /// 更改后值
        /// </summary>
        public virtual decimal TargetValue
        {
            get;
            set;
        }

        /// <summary>
        /// 改变类型（原因）
        /// </summary>
        public virtual string ChangeType
        {
            get;
            set;
        }
        /// <summary>
        /// 改变时间
        /// </summary>
        public virtual DateTime LogTime
        {
            get;
            set;
        }
    }
}
