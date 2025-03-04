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

namespace DVLD.People
{
    public partial class fmShowPersonInfo : Form
    {

        public fmShowPersonInfo(int Id)
        {
            InitializeComponent();
            ctrlPersonCard.loadPersonInfo(Id);
        }

        //public fmShowPersonInfo(string NationalNa)
        //{
        //    InitializeComponent();
        //    ctrlPersonCard1.loadPersonInfo(National);
        //}

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }

        private void fmShowPersonInfo_Load(object sender, EventArgs e)
        {
          
        }
    }
}
