using RestaurantManager.DAO;
using RestaurantManager.DTO;
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
    public partial class UpdateMaterialsSubForm : Form
    {
        public UpdateMaterialsSubForm()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        MaterialDAO Material_DAO = new MaterialDAO();
        MaterialDTO Material_DTO;
        public void FillTheInfoTextbox(int MaterialID)
        {
            Material_DTO = Material_DAO.GetOne(MaterialID, ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);

            NameTextbox.Text = Material_DTO.Name;
            UnitTextbox.Text = Material_DTO.Unit;
            QuantityTextbox.Text = Material_DTO.Quantity.ToString();
            EmployeeIDTextbox.Text = Material_DTO.ManagerID.ToString();
            QuantityLimitTextbox.Text = Material_DTO.QuantityLimit.ToString();
        }

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
            Material_DAO.Update(new MaterialDTO(
                Material_DTO.ID,
                NameTextbox.Text,
                UnitTextbox.Text,
                quantity,
                employeeID,
                quantityLimit
                ), ref ErrMsg);
            ShowMessage.CheckAndShowErr(ref ErrMsg);
            if (ErrMsg == null) { MessageBox.Show("Cập nhật nguyên liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
