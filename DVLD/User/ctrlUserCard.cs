using DVLD.People.Controls;
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
    public partial class ctrlUserCard : UserControl
    {
        clsUser User;
        public ctrlUserCard()
        {

            InitializeComponent();
        }
        public void LoadUserInfo(int UserID)
        {
            User = clsUser.FindUserByID(UserID);

            if(User == null)
            {
                MessageBox.Show("no user found");
                return;
            }

            ctrlPersonCard.loadPersonInfo(User.personID);
            lblUserName.Text = User.userName.ToString();
            lblUserID.Text = User.userID.ToString();
            lblIsActive.Text = User.isActive.ToString();

        }
        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
