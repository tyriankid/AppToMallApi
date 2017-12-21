using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class CreateOrderResponse : MallResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo
        {
            get;
            set;
        }

        public string OrderID { get; set; }

        public decimal TotleMoney { get; set; }
        public decimal Discount { get; set; }
    }
}
