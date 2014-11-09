using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSManagement.DLL.DAO;

namespace POSManagement.DLL.GATEWAY
{
    class ProductGateway
    {

       SqlConnection aConnection = new SqlConnection();
        public ProductGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentDBConnectionStr"].ConnectionString;
            aConnection.ConnectionString = connectionString;
        }

        public bool Save(Product aProduct)
        {
            aConnection.Open();
            string quary = String.Format("INSERT INTO t_product VALUES('{0}','{1}','{2}')", aProduct.ProductCode, aProduct.ProductName,aProduct.ProductQuantity);

            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();

            if (total > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Product> GetAllTems()
        {

            aConnection.Open();
            string query = string.Format("SELECT * FROM t_product");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Product>products = new List<Product>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    
                        Product aProduct = new Product();
                       // aProduct.ProductID = (int) aReader[0];
                        aProduct.ProductCode = aReader[0].ToString();
                        aProduct.ProductName = aReader[1].ToString();
                        aProduct.ProductQuantity = aReader[2].ToString();
                         products.Add(aProduct);
                    
                }
              
            }
            aConnection.Close();
            return products;

        }

        public bool HashThisCodeAlreadySystem(string Code)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_product WHERE product_code='{0}'", Code);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }


        public bool HashThisNameAlreadySystem(string Name)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_product WHERE product_name='{0}'", Name);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }

        public  int GetTotals()
        {
            aConnection.Open();
            //string query = string.Format("SELECT SUM(product_quantity)FROM t_product");
            string query = string.Format("select*from t_product");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool  msg = aReader.HasRows;
            int i=0;
            if (true)
            {
                while (aReader.Read())
                {
                    i += (int) aReader[3];
                }
            }
            aConnection.Close();
            return i;
        }
    }
}
