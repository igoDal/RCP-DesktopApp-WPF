using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP
{
    public class Product
    {
        public int ProductID { get; set; }
        public DateOnly RCPDate { get; set; }
        public TimeOnly RCPTime { get; set; }
        public int RCPType { get; set; }
        public int RCPKind { get; set; }

        public virtual Category Category { get; set; }
    }
}
