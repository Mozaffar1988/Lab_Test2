using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerArchitecture.DLL.DAO;

namespace LayerArchitecture.DLL.GATEWAY
{
    class DepartmentGateway
    {
       //private SqlConnection aConnection;
        
        SqlConnection aConnection = new SqlConnection();
        public DepartmentGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentDBConnectionStr"].ConnectionString;
            //aConnection.ConnectionString = connectionString;
            aConnection.ConnectionString = connectionString;
        }

        public bool Save(Department aDepartment)
        {
            aConnection.Open();
            string quary = String.Format("INSERT INTO t_department VALUES('{0}','{1}')", aDepartment.departmentName, aDepartment.departmentCode);
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

        public bool HashThisCodeAlreadySystem( string Code)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_department WHERE department_code='{0}'", Code);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }


        public bool HashThisNameAlreadySystem(string Name)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_department WHERE department_name='{0}'", Name);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }



        public List<Department> GetAllDepartment()
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_department");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Department> departments = new List<Department>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment = new Department();
                    aDepartment.departmentID = (int)aReader[0];
                    aDepartment.departmentName = aReader[1].ToString();
                    aDepartment.departmentCode = aReader[2].ToString();
                    departments.Add(aDepartment);
                }
            }
            aConnection.Close();
            return departments;
        }
    }
}
