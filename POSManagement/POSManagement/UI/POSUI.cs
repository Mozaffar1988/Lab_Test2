using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSManagement.BLL;
using POSManagement.DLL.DAO;

namespace POSManagement
{
    public partial class POSUI : Form
    {
        public POSUI()
        {
            InitializeComponent();
            
        }
        ProductBLL aProductBll = new ProductBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();
            aProduct.ProductCode = CodeTextBox.Text;
            aProduct.ProductName = nameTextBox.Text;
            aProduct.ProductQuantity =quantityTextBox.Text;
            string msg = aProductBll.Save(aProduct);
            MessageBox.Show(msg);

            

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = aProductBll.GetAllTem();
            totalQuantityTextBox.Text = aProductBll.GetTOTal().ToString();
        }
    }
}
