using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{

    public class ScanCodeResponse : MallResponse
    {
       public string TransID { get; set; }

       public string StateMsg { get; set; }

       public int State { get; set; }

       public bool IsSuccess { get; set; }

       public bool IsFinish { get; set; }

       public DateTime StartTime { get; set; }

       public DateTime Consumetime { get; set; }

       public DateTime FinishTime { get; set; }
   }
}
