﻿using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
   
    public class OrderChangStatusRequest : BaseRequest, IMallRequest<MallResponse>
    {
        ///// <summary>
        ///// 商户ID
        ///// </summary>
        //public string BussinessID { get; set; }
        /// <summary>
        /// 订单号码
        /// </summary>
        public string TPOrderNo { get; set; }
        /// <summary>
        /// 变更类型
        /// </summary>
        public int Type { get; set; }
    }
}
