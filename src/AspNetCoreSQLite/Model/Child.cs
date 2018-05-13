using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSQLite.Model
{
    public class Child : Base
    {
        

       

        public string DOB { get; set; }

        public string Avatar { get; set; }

        public string Nick { get; set; }
        
        public int Year { get; set; }

        public short Gender { get; set; }

    }
}
