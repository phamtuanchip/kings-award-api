using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Archive : Base
    {
        public string DateTime { get; set; }
        long childrenId { get; set; }
        long awardsId { get; set; }
        long ArchivePoints { get; set; }
        List<TaskDone> TaskDone { get; set; }
    }
}
