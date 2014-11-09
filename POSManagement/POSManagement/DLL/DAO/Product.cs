using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagement.DLL.DAO
{
    class Product
    {
       // public int  ProductID { get; set; }
        public string ProductCode { get; set; }
        public  string ProductName { get; set; }
        public String  ProductQuantity { get; set; }

        internal void Add(Product aProduct)
        {
            throw new NotImplementedException();
        }
    }
}
