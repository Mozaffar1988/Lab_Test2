using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerArchitecture.DLL.DAO;
using LayerArchitecture.DLL.GATEWAY;

namespace LayerArchitecture.BLL
{
    class DepartmentBLL
    {
        private DepartmentGateway aDepartmentGateway;

        public DepartmentBLL()
        {
            aDepartmentGateway = new DepartmentGateway();
        }

        public string Save(Department aDepartment)
        {
            if (aDepartment.departmentName == "" || aDepartment.departmentCode == "")
            {
                string info = "";
                if (aDepartment.departmentName == "")
                {
                    info += " Fill up name firld\n";

                }
                if (aDepartment.departmentCode == "")
                {
                    info += "Fill up Code firld";
                }
                return info;

            }
                           
            else
            {
                if (HashThisCodeAlreadySystem(aDepartment.departmentCode) || HashThisNameAlreadySystem(aDepartment.departmentName))
                {
                    string msg = "";
                    if (HashThisCodeAlreadySystem(aDepartment.departmentCode))
                        msg += "Code already in system\n";
                    if (HashThisNameAlreadySystem(aDepartment.departmentName))
                        msg += "name already in system";
                    return msg;
                }
                else
                {
                    if (aDepartmentGateway.Save(aDepartment))
                    {
                        return "department insert success";
                    }

                    return "problem";
                }
            }

        }

        private bool HashThisCodeAlreadySystem( String Code)
        {
            return aDepartmentGateway.HashThisCodeAlreadySystem(Code);
        }

        private bool HashThisNameAlreadySystem(String Name)
        {
            return aDepartmentGateway.HashThisCodeAlreadySystem(Name);
        }

        public List<Department> GetAllDepartment()
        {
            return aDepartmentGateway.GetAllDepartment();
        }
    }
}
