using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Task : Base
    {
      
       int  DefaultPoint { get; set; }
       int ManualPoint { get; set; }
    }
}
