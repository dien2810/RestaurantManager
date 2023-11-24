using RestaurantManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.GUI.UserControls
{
    public partial class UC_ProductList : UserControl
    {
        public UC_ProductList()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        ProductDAO Product_DAO = new ProductDAO();

        private void UC_ProductList_Load(object sender, EventArgs e)
        {
            DataTable DT = Product_DAO.GetAll(ref ErrMsg);

            // add each product to panel
            int i = 0;
            foreach (DataRow dr in DT.Rows) 
            { 
                UC_ProductItem item = new UC_ProductItem();
                item.NameOfProduct = dr[1].ToString();
                item.Price = int.Parse(dr[2].ToString());
                item.ProductID = i + 1;
                item.Width = Width - 80;

                ListProductflowLayoutPanel.Controls.Add(item);
                i++;
            }
        }
    }
}
