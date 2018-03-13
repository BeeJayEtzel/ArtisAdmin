using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtisAdmin
{
    public partial class ManageUsers : Form
    {
        ARTISLAB.ResUser myUser;
        DataTable searchResults;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            ClearTextFields();

            searchResults = Program.ARTISClient.usernameContains(txtUsername.Text);

            DataTable privLevels = Program.ARTISClient.getPrivLevels();

            if (searchResults.Rows.Count > 0)
            {
                foreach (DataRow row in searchResults.Rows)
                {
                    dgvSearchResults.Rows.Add(row["Username"], row["Notes"]);
                }
            }
            else
            {
                ArtisMessage msg = new ArtisMessage("No user containing " + txtUsername.Text + " found!");
                msg.ShowDialog();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            lblFoundUser.Text = "";
            lblFoundPrivLevel.Text = "";
            lblFoundDateCreated.Text = "";
            lblFoundNotes.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            ArtisDialog dialog = new ArtisDialog("Are you sure you want to update user " + myUser.Username + " ?");
            result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                myUser.Username = txtEditUserName.Text;
                if (myUser.Password != txtEditPassword.Text)
                {
                    myUser.Password = txtEditPassword.Text;
                }
                myUser.PrivLevel = comboPrivLevel.Text;
                myUser.Notes = txtEditNotes.Text;
                Program.ARTISClient.saveResUser(myUser, Program.TOKEN);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            ArtisDialog dialog = new ArtisDialog("Are you sure you want to delete user " + myUser.Username + " ?");
            result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Program.ARTISClient.deleteResUser(myUser.Username, Program.TOKEN);
            }

        }

        private void ClearTextFields()
        {
            txtEditUserName.Text = "";
            txtEditNotes.Text = "";
            txtEditPassword.Text = "";
            txtEditNotes.Text = "";
            comboPrivLevel.Items.Clear();
            comboPrivLevel.SelectedIndex = -1;
            //clear FOUND lables
            lblFoundUser.Text = "";
            lblFoundPrivLevel.Text = "";
            lblFoundDateCreated.Text = "";
            lblFoundPrivLevel.Text = "";
            lblFoundNotes.Text = "";

        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            myUser = Program.ARTISClient.getResUser(txtUsername.Text , Program.TOKEN);
            DataTable privLevels = Program.ARTISClient.getPrivLevels();

            if (searchResults != null)
            {
                
                lblFoundUser.Text = myUser.Username;
                lblFoundDateCreated.Text = myUser.CreateDate.ToString();
                lblFoundPrivLevel.Text = myUser.PrivLevel;
                lblFoundNotes.Text = myUser.Notes;

                txtEditUserName.Text = myUser.Username;
                txtEditPassword.Text = myUser.Password;
                txtEditNotes.Text = myUser.Notes;
                
                //Add the PrivLevels to combobox
                foreach (DataRow row in privLevels.Rows)
                {
                    comboPrivLevel.Items.Add(row["PrivLevel"]);
                }
                comboPrivLevel.SelectedItem = myUser.PrivLevel;
                
            }
            else
            {
                ArtisMessage msg = new ArtisMessage("User Not Found!");
                msg.ShowDialog();
            }
        }

        private void dgvSearchResults_SelectionChanged(object sender, EventArgs e)
        {
            String selectedUser = dgvSearchResults.SelectedRows[0].Cells[0].Value.ToString();
            myUser = Program.ARTISClient.getResUser(selectedUser, Program.TOKEN);
            DataTable privLevels = Program.ARTISClient.getPrivLevels();

            if (myUser.dbMessage == "Found")
            {

                lblFoundUser.Text = myUser.Username;
                lblFoundDateCreated.Text = myUser.CreateDate.ToString();
                lblFoundPrivLevel.Text = myUser.PrivLevel;
                lblFoundNotes.Text = myUser.Notes;

                txtEditUserName.Text = myUser.Username;
                txtEditPassword.Text = myUser.Password;
                txtEditNotes.Text = myUser.Notes;

                //Add the PrivLevels to combobox
                foreach (DataRow row in privLevels.Rows)
                {
                    comboPrivLevel.Items.Add(row["PrivLevel"]);
                }
                comboPrivLevel.SelectedItem = myUser.PrivLevel;

            }
            else
            {
                ArtisMessage msg = new ArtisMessage("User Not Found!");
                msg.ShowDialog();
            }
        }

        private void btnFindByNotes_Click(object sender, EventArgs e)
        {
            ClearTextFields();
            searchResults = Program.ARTISClient.notesContains(txtFindByNotes.Text);
            DataTable privLevels = Program.ARTISClient.getPrivLevels();

            if (searchResults.Rows.Count > 0)
            {
                foreach (DataRow row in searchResults.Rows)
                {
                    dgvSearchResults.Rows.Add(row["Username"], row["Notes"]);
                }
            }
            else
            {
                ArtisMessage msg = new ArtisMessage("No users with notes containing " + txtFindByNotes.Text + " found!");
                msg.ShowDialog();
            }
        }
    }
}
