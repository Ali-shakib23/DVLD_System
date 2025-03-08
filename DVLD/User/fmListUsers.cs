using DVLD.People;
using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.User
{
    public partial class fmListUsers : Form
    {
        //public static DataTable _dtAllUsers = clsUser.GetAllUsers();

        //private DataTable _dtUser = _dtAllUsers.DefaultView.ToTable(false, "PersonID", "FullName",
        //                                            "UserName", "IsActive");

        public fmListUsers()
        {
            InitializeComponent();
            
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fmListUsers_Load(object sender, EventArgs e)
        {
            DataTable _dtAllUsers = clsUser.GetAllUsers();

            dgvUsers.DataSource = _dtAllUsers;
            
            cbFilterBy.SelectedIndex = 0;
            if (dgvUsers.Rows.Count > 0)
            {


                //lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();

                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 350;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 120;
            }
        }

        private void cmsUsers_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserId = (int)dgvUsers.CurrentRow.Cells[0].Value;
            fmAddUpdateUser EditPerson = new fmAddUpdateUser(UserId);
            EditPerson.Show();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserId = (int)dgvUsers.CurrentRow.Cells[0].Value;
            fmUserInfo userInfo = new fmUserInfo(UserId);

            userInfo.Show();
        }

        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmChangePassword changePassword = new fmChangePassword();
            changePassword.Show();
        }
    }
}
