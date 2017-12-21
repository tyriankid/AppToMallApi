using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/SaveReceiveAddressOnLine")]
    /// <summary>
    /// 线上保存收货地址信息
    /// </summary>
    public class SaveReceiveAddressRequest : BaseRequest, IMallRequest<MallResponse>
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id
        {
            get;
            set;
        }
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
    }
}
