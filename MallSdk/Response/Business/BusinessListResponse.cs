using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk;

namespace MallSdk
{
    /// <summary>
    /// 门店地址列表
    /// </summary>
    public class BusinessListResponse : MallResponse
    {
        public List<DTOBusinessItem> list { get; set; }
    }
    public class DTOBusinessItem 
    {
        /// <summary>
        /// 商户名称
        /// </summary>
        public string BusinessName { get; set; }


        /// <summary>
        /// 商户ID
        /// </summary>
        public string BussinessID { get; set; }

        /// <summary>
        /// 商户地址
        /// </summary>
        public virtual string Address
        {
            get;
            set;
        }
        /// <summary>
        /// 商户url
        /// </summary>
        public string BussinessUrl { get; set; }
    }
}
