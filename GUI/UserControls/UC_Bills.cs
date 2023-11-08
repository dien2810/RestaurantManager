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
    public partial class UC_Bills : UserControl
    {
        public UC_Bills()
        {
            InitializeComponent();
        }

        private void BillsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Bills_Load(object sender, EventArgs e)
        {
            string Msg = "";
            int Month = int.Parse(DateTime.Now.ToString("MM"));
            BillDG.DataSource = DataProvider.ExecuteQuery("SELECT * FROM HoaDonTheoThangCuaNam(2023, " + Month + ")", ref Msg);
        }

        private void BillDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
