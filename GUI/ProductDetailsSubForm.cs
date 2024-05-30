using RestaurantManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.GUI
{
    public partial class ProductDetailsSubForm : Form
    {
        public ProductDetailsSubForm()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        public void FillTheInfo(int ProductID)
        {
            DataTable DT = DataProvider.ExecuteQuery("SELECT * FROM V_SanPhamVaNguyenLieu WHERE MaSP = " + ProductID.ToString(), ref ErrMsg);
            if (ErrMsg != null)
            {                
                throw new Exception("Ban khong duoc phep truy cap chuc nang nay");
            }
            TitleLbl.Text = "Chi tiết sản phẩm " + DT.Rows[0].ItemArray[1].ToString();
            PriceLbl.Text = "Giá: " + DT.Rows[0].ItemArray[2].ToString();
            foreach (DataRow dr in DT.Rows)
            {
                DataGridViewRow dataRow = (DataGridViewRow)ProductDetailsDG.Rows[0].Clone();
                dataRow.Cells[0].Value = dr[3];
                dataRow.Cells[1].Value = dr[4];
                dataRow.Cells[2].Value = dr[5];
                ProductDetailsDG.Rows.Add(dataRow);
            }
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
