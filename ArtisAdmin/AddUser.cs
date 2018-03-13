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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            DataTable privLevels = Program.ARTISClient.getPrivLevels();

            foreach (DataRow row in privLevels.Rows)
            {
                comboPrivLevel.Items.Add(row["PrivLevel"]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ARTISLAB.ResUser newUser = new ARTISLAB.ResUser();
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPassword.Text;
            newUser.Notes = txtNotes.Text;
            newUser.CreateDate = DateTime.Today;
            newUser.PrivLevel = comboPrivLevel.SelectedItem.ToString();

            Program.ARTISClient.insertResUser(newUser, Program.TOKEN);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
