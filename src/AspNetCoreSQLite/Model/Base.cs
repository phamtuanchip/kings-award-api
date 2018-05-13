using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Base
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Byte[] Data { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Date { get; set; }
    }
}
