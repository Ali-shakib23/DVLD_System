using DVLD.Properties;
using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        int _PersonID = -1;
        clsPerson _Person;

        public void ResetInfo()
        {
           
                _PersonID = -1;
                lblPersonID.Text = "[????]";
                lblNationalNo.Text = "[????]";
                lblFullName.Text = "[????]";
                lblGendor.Text = "[????]";
                lblEmail.Text = "[????]";
                lblPhone.Text = "[????]";
                lblDateOfBirth.Text = "[????]";
                lblCountry.Text = "[????]";
                lblAddress.Text = "[????]";
                pbPersonImage.Image = Resources.Male_512;

            
        }

        public void loadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ResetInfo();
                return;
            }
            
            lblPersonID.Text = _Person.PersonID.ToString();
            
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FullName;
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblAddress.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;

        }
        public ctrlPersonCard()
        {
            InitializeComponent();
           
            
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
