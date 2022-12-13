using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Product>
            Products
        { get; private set; } =
            new ObservableCollection<Product>();
    }
}
