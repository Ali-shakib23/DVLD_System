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

namespace DVLD.User
{
    public partial class fmAddUpdateUser : Form
    {
        private int _Id = -1;
        public fmAddUpdateUser()
        {
            InitializeComponent();
        }

        public fmAddUpdateUser(int UserID)
        {
            _Id = UserID;
            InitializeComponent();
        }

        public void fmUpdateLoad()
        {
            if (clsUser.isUserExist(_Id))
            {
               clsUser user = clsUser.FindUserByID(_Id);

                if (user != null)
                {
                    txtUserName.Text = user.userName.ToString();
                    txtPassword.Text = user.password.ToString();
                }
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter2_Load(object sender, EventArgs e)
        {

        }
    }
}
