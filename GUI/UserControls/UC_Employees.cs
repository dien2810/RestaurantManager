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

namespace RestaurantManager.GUI.UserControls
{
    public partial class UC_Employees : UserControl
    {
        public UC_Employees()
        {
            InitializeComponent();
        }
        string ErrMsg = null;
        EmployeeDAO Employee_DAO = new EmployeeDAO();

        private void UC_Employees_Load(object sender, EventArgs e)
        {
            EmployeesDG.DataSource = Employee_DAO.GetAll(ref ErrMsg);
        }

        private void TableSetBtn_Click(object sender, EventArgs e)
        {
            AddEmployeesSubForm addEmployeesSubForm = new AddEmployeesSubForm();
            addEmployeesSubForm.ShowDialog();
            UC_Employees_Load(sender, e);
        }

        private void EmployeesDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateEmployeeBtn.Enabled = true;
            DeleteEmployeeBtn.Enabled = true;
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            //get the value of EmployeeID
            int selectedRowIndex = EmployeesDG.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = EmployeesDG.Rows[selectedRowIndex];
            int selectedEmployeeID = Convert.ToInt16(selectedRow.Cells[0].Value);

            // confirm box here
            if (ShowMessage.ConfirmationBox("Bạn có chắc chắn muốn xoá nhân viên có mã " + selectedEmployeeID.ToString() + "?"))
            {
                Employee_DAO.Delete(selectedEmployeeID, ref ErrMsg);

                ShowMessage.CheckAndShowErr(ref ErrMsg);
                if (ErrMsg == null) { MessageBox.Show("Xoá nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                UC_Employees_Load(sender, e);
            }
        }
    }
}
