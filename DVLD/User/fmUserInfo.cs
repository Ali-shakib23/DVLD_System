using DVLD.People.Controls;
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
    public partial class fmUserInfo : Form
    {
        private int _UserID;
        public fmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void fmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard.LoadUserInfo(_UserID);
           
        }

        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
