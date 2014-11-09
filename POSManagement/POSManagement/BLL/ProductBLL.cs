using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSManagement.DLL.DAO;
using POSManagement.DLL.GATEWAY;

namespace POSManagement.BLL
{
    class ProductBLL
    {
        private ProductGateway aProductGateway;


        public ProductBLL()
        {
            aProductGateway = new ProductGateway();
        }

        public string Save(Product aProduct)
        {
            if ((aProduct.ProductCode.Length > 3 || aProduct.ProductCode.Length < 3) || (aProduct.ProductName.Length < 5 || aProduct.ProductName.Length > 10) || (aProduct.ProductQuantity == ""))
            {
                string info = "";
                if (aProduct.ProductCode.Length >3 || aProduct.ProductCode.Length<3)
                {
                    info += "Your Code Not 3 Character\n";
                }
                if (aProduct.ProductName.Length <5 || aProduct.ProductName.Length>10)
                {
                    info += "Your Name Not 5-10 Character\n";
                }
                if (aProduct.ProductQuantity == "")
                {
                    info += "Quantity balnk";
                }

                return info;

            }
            else
            {
                if (HashThisCodeAlreadySystem(aProduct.ProductCode) || HashThisNameAlreadySystem(aProduct.ProductName))
                {
                    string msg = "";
                    if (HashThisCodeAlreadySystem(aProduct.ProductCode))
                        msg += "Code already in system\n";
                    if (HashThisNameAlreadySystem(aProduct.ProductName))
                        msg += "name already in system";
                    return msg;
                }
                
                else
                if (aProductGateway.Save(aProduct))
                {
                    return "Insert data Succed";
                }
                else
                {
                    return "Not Insert have a some problem";
                }
            }
        }


        private bool HashThisCodeAlreadySystem(String Code)
        {
            return aProductGateway.HashThisCodeAlreadySystem(Code);
        }

        private bool HashThisNameAlreadySystem(String Name)
        {
            return aProductGateway.HashThisNameAlreadySystem(Name);
        }

      
        public List<Product> GetAllTem()
        {
            return aProductGateway.GetAllTems();
        }

        public int GetTOTal()
        {
            return aProductGateway.GetTotals();
        }
    }
}
