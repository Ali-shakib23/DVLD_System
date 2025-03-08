using DVLD.User;
using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Login
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        
        private void fmLogin_Load(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            if (getCredientials(ref username, ref password))
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
                chkRememberMe.Checked = true; 
            }
            else
            {
                chkRememberMe.Checked = false;
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        public bool RememberUsernameAndPassword(string username, string password)
        {
            bool isFound = false;
            try
            {

                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                string credeintials = username + "#//#" + password;

                string filePath = currentDirectory + "\\data.txt";

                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(credeintials);

                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            return isFound;
        }

        public bool getCredientials(ref string username, ref string password)
        {
            string currentDierctory = System.IO.Directory.GetCurrentDirectory();

            string filePath = currentDierctory + "\\data.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        string[] con = line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                        username = con[0];
                        password = "1234";


                    }
                    return true;
                }
            }
            return false;
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindUserByUserNameAndPassword(txtUserName.Text.ToString().Trim(), txtPassword.Text.ToString().Trim());
            if (user != null)
            {
                if (chkRememberMe.Checked)
                {
                    RememberUsernameAndPassword(txtUserName.Text.ToString(), txtPassword.Text.ToString());
                }
                else
                {
                    RememberUsernameAndPassword("", "");
                }

                if (user.isActive == false)
                {
                    MessageBox.Show("your account is Active");
                }
                fmListUsers fmListUsers = new fmListUsers();
                fmListUsers.Show();
            }
            else
            {
                MessageBox.Show("this is invalid userName or password");
            }


        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
           

            

        }
    }
}
