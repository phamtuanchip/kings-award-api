using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Archive : Base
    {
        public string DateTime { get; set; }
        public long childrenId { get; set; }
        public long awardsId { get; set; }
        public long ArchivePoints { get; set; }
        public List<TaskDone> TaskDone { get; set; }
    }
}
