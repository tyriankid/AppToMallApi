using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MallRouteAttribute : Attribute
    {
        public MallRouteAttribute(string path)
        {
            this.Path = path;
        }
        public string Path { get; set; }
    }
}
