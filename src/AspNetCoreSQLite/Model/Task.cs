using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Task : Base
    {
      
      public int  DefaultPoint { get; set; }
        public int ManualPoint { get; set; }
    }
}
