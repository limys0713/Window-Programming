using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public string link, user, password;         //declare variable
        List<Account> saveInfo = new List<Account>();
        bool check = true;
        public string substring = null;
        public string checkPass = null;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            substring = txtSearch.Text;
            if (substring == null)
            {
                for (int n = 0; n < saveInfo.Count; n++)
                {
                    if (saveInfo[n].link != null && saveInfo[n].user != null && saveInfo[n].pass != null)     //if not null, then print the info out
                    {
                        labelResult.Text += "Link: " + saveInfo[n].link;
                        labelResult.Text += "\nUser: " + saveInfo[n].user;            //+=
                        labelResult.Text += "\nPassword: " + saveInfo[n].pass;
                        labelResult.Text += "\n===============";
                        labelResult.Text += "\n";
                    }
                }
            }
            else if(substring != null)
            {
                for (int n = 0; n < saveInfo.Count; n++)
                {
                    if (saveInfo[n].link != null && saveInfo[n].link.Contains(substring))     //if the link contains the word searched, then print it out
                    {
                        labelResult.Text += "Link: " + saveInfo[n].link;
                        labelResult.Text += "\nUser: " + saveInfo[n].user;
                        labelResult.Text += "\nPassword: " + saveInfo[n].pass;
                        labelResult.Text += "\n===============";
                        labelResult.Text += "\n";
                    }
                }
            }
        }
        
        private void AddDelete_Click(object sender, EventArgs e)
        {
            Statusbar.Text = "Status bar";
            labelSearch.Visible = false;
            labelSearch.Enabled = false;
            txtSearch.Visible = false;
            txtSearch.Enabled = false;
            SearchButton.Visible = false;
            SearchButton.Enabled = false;
            RiskyAccountButton.Visible = false;
            RiskyAccountButton.Enabled = false;
            Statusbar.Visible = true;
            Statusbar.Enabled = true;
            labelLink.Visible = true;
            labelLink.Enabled = true;
            labelUser.Visible = true;
            labelUser.Enabled = true;
            labelPassword.Visible = true;
            labelPassword.Enabled = true;
            txtLink.Visible = true;
            txtLink.Enabled = true;
            txtUser.Visible = true;
            txtUser.Enabled = true;
            txtPassword.Visible = true;
            txtPassword.Enabled = true;
            labelSearchResult.Visible = false;
            labelSearchResult.Enabled = false;
            labelResult.Visible = false;
            labelResult.Enabled = false;
            buttonAdd.Visible = true;
            buttonAdd.Enabled = true;
            buttonDelete.Visible = true;
            buttonDelete.Enabled = true;
            buttonReturnMenu.Visible = true;
            buttonReturnMenu.Enabled = true;
            AddDelete.Visible = false;
            AddDelete.Enabled = false;
        }

        private void RiskyAccountButton_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            for (int n = 0; n < saveInfo.Count; n++)
            {
                for(int m = 0; m < saveInfo.Count; m++)     //check whether the password is same    //**m=n
                {
                    if(saveInfo[n].pass == saveInfo[m].pass && n != m && saveInfo[n].pass != null && saveInfo[m].pass != null)
                    {
                        labelResult.Text += "Link: " + saveInfo[n].link;
                        labelResult.Text += "\nUser: " + saveInfo[n].user;
                        labelResult.Text += "\nPassword: " + saveInfo[n].pass;
                        labelResult.Text += "\n===============";
                        labelResult.Text += "\n";
                        break;
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            check = true;
            link = txtLink.Text;
            user = txtUser.Text;
            password = txtPassword.Text;
            for (int n = 0; n < saveInfo.Count; n++)
            {
                if (saveInfo[n].link != null && saveInfo[n].user != null && saveInfo[n].pass != null)     //if not null
                {
                    if (saveInfo[n].link == link && saveInfo[n].user == user && saveInfo[n].pass == password && check == true)      //delete info
                    {
                        saveInfo.RemoveAt(n);
                        check = false;
                        Statusbar.Text = "Deleted successfully";
                    }
                }
            }
            if (check == true)
            {
                Statusbar.Text = "Account doesn't exist or incorrect password";
            }
            txtLink.Clear();            //clear the textbox
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            labelResult.Text = "";
            labelSearch.Visible = true;
            labelSearch.Enabled = true;
            txtSearch.Visible = true;
            txtSearch.Enabled = true;
            SearchButton.Visible = true;
            SearchButton.Enabled = true;
            RiskyAccountButton.Visible = true;
            RiskyAccountButton.Enabled = true;
            Statusbar.Visible = false;
            Statusbar.Enabled = false;
            labelLink.Visible = false;
            labelLink.Enabled = false;
            labelUser.Visible = false;
            labelUser.Enabled = false;
            labelPassword.Visible = false;
            labelPassword.Enabled = false;
            txtLink.Visible = false;
            txtLink.Enabled = false;
            txtUser.Visible = false;
            txtUser.Enabled = false;
            txtPassword.Visible = false;
            txtPassword.Enabled = false;
            labelSearchResult.Visible = true;
            labelSearchResult.Enabled = true;
            labelResult.Visible = true;
            labelResult.Enabled = true;
            buttonAdd.Visible = false;
            buttonAdd.Enabled = false;
            buttonDelete.Visible = false;
            buttonDelete.Enabled = false;
            buttonReturnMenu.Visible = false;
            buttonReturnMenu.Enabled = false;
            AddDelete.Visible = true;
            AddDelete.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            check = true;
            link = txtLink.Text;
            user = txtUser.Text;
            password = txtPassword.Text;

            for (int n=0; n< saveInfo.Count; n++)
            {
                if (saveInfo[n].link != null && saveInfo[n].user != null)     //if not null, then check 
                {
                    if (saveInfo[n].link == link && saveInfo[n].user == user)
                    {
                        Statusbar.Text = "Account already exists";
                        check = false;
                        break;
                    }
                }
            }
            if (check == true)
            {

                saveInfo.Add(new Account(link,user,password));
                Statusbar.Text = "Added Successfully";
            }
            txtLink.Clear();            //clear the textbox
            txtUser.Clear();
            txtPassword.Clear();
        }

    }
}
