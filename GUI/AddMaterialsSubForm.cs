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

namespace RestaurantManager.GUI
{
    public partial class AddMaterialsSubForm : Form
    {
        public AddMaterialsSubForm()
        {
            InitializeComponent();
        }
        MaterialDAO Material_DAO = new MaterialDAO();
        string ErrMsg = null;
        private void AddMaterialBtn_Click(object sender, EventArgs e)
        {
            int quantity;
            int employeeID;
            int quantityLimit;
            if (int.TryParse(QuantityTextbox.Text, out quantity) == false)
            {
                MessageBox.Show("Số lượng phải là số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (int.TryParse(EmployeeIDTextbox.Text, out employeeID) == false)
            {
                MessageBox.Show("Mã nhân viên quản lý phải là số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (int.TryParse(QuantityLimitTextbox.Text, out quantityLimit) == false)
            {
                MessageBox.Show("Số lượng tồn kho phải là số nguyên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Material_DAO.Insert(new DTO.MaterialDTO(
                0,
                NameTextbox.Text,
                UnitTextbox.Text,
                quantity,
                employeeID,
                quantityLimit)
                , ref ErrMsg);
                if (ShowMessage.CheckAndShowErr(ref ErrMsg)) { MessageBox.Show("Thêm nguyên liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
