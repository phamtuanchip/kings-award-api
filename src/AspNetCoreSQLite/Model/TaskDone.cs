using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class TaskDone : Base
    {
        public long  tasksId { get; set; }
        public int Point { get; set; }
    }
}
