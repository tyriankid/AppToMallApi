using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetReceiveAddressListResponse : MallResponse
    {
        public List<ReceiveAddressDetailsResponse> List { get; set; }
    }
    public class ReceiveAddressDetailsResponse : MallResponse
    {
        public string Id { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LgBaseId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address
        {
            get;
            set;
        }
        /// <summary>
        /// 地区
        /// </summary>
        public string Area
        {
            get;
            set;
        }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string Phone
        {
            get;
            set;
        }
        /// <summary>
        /// 是否默认地址
        /// </summary>
        public bool IsDefault
        {
            get;
            set;
        }
    }
}
