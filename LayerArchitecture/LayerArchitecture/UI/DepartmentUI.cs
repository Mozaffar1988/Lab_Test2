using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayerArchitecture.BLL;
using LayerArchitecture.DLL.DAO;


namespace LayerArchitecture.UI
{
    public partial class DepartmentUI : Form
    {
        public DepartmentUI()
        {
            InitializeComponent();
            GetAllDepartment();
        }

      
        DepartmentBLL aDepartmentBll = new DepartmentBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
          Department aDepartment = new Department();
            aDepartment.departmentName = nameTextBox.Text;
            aDepartment.departmentCode = codeTextBox.Text;
            string msg = aDepartmentBll.Save(aDepartment);
            MessageBox.Show(msg);
            GetAllDepartment();

        }

        private void GetAllDepartment()
        {
            departmentGridView.DataSource = aDepartmentBll.GetAllDepartment();
        }
    }
}
