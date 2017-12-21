using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class ShareOnLineResponse : MallResponse
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID
        {
            get;
            set;
        }
        /// <summary>
        /// ShareId
        /// </summary>
        public Guid ShareId
        {
            get;
            set;
        }
        /// <summary>
        /// 会员名称
        /// </summary>
        public string LeaguerName
        {
            get;
            set;
        }
        /// <summary>
        /// 分享类型名
        /// </summary>
        public string ShareTypeName
        {
            get;
            set;
        }
        /// <summary>
        /// 商品类型名
        /// </summary>
        public string GoodsTypeName
        {
            get;
            set;
        }
        /// <summary>
        /// 商品数量
        /// </summary>
        public decimal Number
        {
            get;
            set;
        }
    }
}
