using DVLD.Properties;
using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class fmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        clsPerson _Person;
        enum enMode { Add = 0,Update = 1}
        enMode _Mode;
        int _Id = -1;

        // this is for the add
        public fmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.Add;
            
        }

        //this is for the edit 
        public fmAddUpdatePerson(int PersonId)
        {
            
            InitializeComponent();
            _Id = PersonId;
            _Mode = enMode.Update;
            
        }

        private void Initilazefunc()
        {
            LoadAllCountries();
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add";
                _Person = new clsPerson();
            }
            else if (_Mode == enMode.Update)
            {
                lblTitle.Text = "Update";
            }
            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            //txtFirstName.Text = "";
            //txtSecondName.Text = "";
            //txtThirdName.Text = "";
            //txtLastName.Text = "";
            //txtNationalNo.Text = "";
            //rbMale.Checked = true;
            //txtPhone.Text = "";
            //txtEmail.Text = "";
            //txtAddress.Text = "";
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbPersonImage.Image = Resources.Female_512;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbPersonImage.Image = Resources.Male_512;
        }
        private void loadData()
        {
            _Person = clsPerson.Find(_Id);
            if (_Person  == null)
            {
                MessageBox.Show("No Person with ID = " + _Id, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblTitle.Text = "Update";
            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtThirdName.Text = _Person.ThirdName;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            
            if (_Person.Gendor == 0)
            {
                rbMale.Checked = true;
            }
            else if(_Person.Gendor == 1)
            {
                rbFemale.Checked = true;
            }
        }

        private void LoadAllCountries()
        {
            DataTable countries = clsCountry.ListAllCountries();

            foreach (DataRow rows in countries.Rows)
            {
                cbCountry.Items.Add(rows["CountryName"]);
            }
        }
        

        private void fmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            
            Initilazefunc();
            if (_Mode == enMode.Update)
            {
                loadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int NationalCountryId = clsCountry.Find(cbCountry.Text).ID;
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();

            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gendor = 0;//(short)enGendor.Male;
            else
                _Person.Gendor = 1; //(short)enGendor.Female;

            _Person.NationalityCountryID = NationalCountryId;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
