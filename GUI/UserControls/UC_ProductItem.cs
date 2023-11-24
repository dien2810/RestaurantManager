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
    public partial class UC_ProductItem : UserControl
    {
        public UC_ProductItem()
        {
            InitializeComponent();
        }
        public string NameOfProduct {  get; set; }
        public int Price { get; set;}
        public int ProductID { get; set;}
        public SetParameterValueDelegate SetParameterValueCallback;


        private void UC_ProductItem_Load(object sender, EventArgs e)
        {
            NameOfProductLbl.Text = NameOfProduct;
            PriceLbl.Text = "Giá: " + Price.ToString();
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            ProductDetailsSubForm productDetailsSubForm = new ProductDetailsSubForm();
            SetParameterValueCallback += new SetParameterValueDelegate(productDetailsSubForm.FillTheInfo);
            SetParameterValueCallback(this.ProductID);
            productDetailsSubForm.ShowDialog();
        }
    }
}
