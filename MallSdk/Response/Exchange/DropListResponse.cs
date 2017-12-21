using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 下拉选择通用DTO
    /// </summary>
    public class DropItemResponse : MallResponse
    {
        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }
      
    }

    public class DropListResponse : MallResponse
    {
        public List<DropItemResponse> Data { get; set; }
    }
}
