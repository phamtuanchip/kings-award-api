using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Award : Base
    {
        public string Title { get; set; }
        public string  SubTitle { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Gift { get; set; } //statics/gift/g1.jpg",
        public int TargetPoint { get; set; } 
    }
}
