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
    public partial class UC_MaterialPurchase : UserControl
    {
        public UC_MaterialPurchase()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        MaterialPurchaseDAO materialPurchaseDAO = new MaterialPurchaseDAO();

        private void UC_MaterialPurchase_Load(object sender, EventArgs e)
        {
            MaterialPurchasesDG.DataSource = materialPurchaseDAO.GetAll(ref ErrMsg);
        }
    }
}
