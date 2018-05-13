using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Activity : Base
    {
       public string DateTime { get; set; } //2018-04-11 12:30",
       public string Title { get; set; }
       public string SubTitle { get; set; }
        public string ItemText { get; set; }
        public string ItemInerText { get; set; }
    }
}
