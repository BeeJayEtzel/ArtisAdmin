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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void updateDeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers();
            form.MdiParent = this;
            form.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usageStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsageStatistics form = new UsageStatistics();
            form.MdiParent = this;
            form.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Program.TOKEN = Program.ARTISClient.logIn(txtUsername.Text, txtPassword.Text);

            if (Program.TOKEN == "Invalid Credentials")
            {
                lblLogInError.Visible = true;
            }
            else
            {
                lblUsername.Visible = false;
                lblPassword.Visible = false;
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                btnLogIn.Visible = false;
                lblLogInError.Visible = false;
                this.Text = "ARTIS Administration System - Logged In";
                ArtisMessage msg = new ArtisMessage("Log In Successful");
                msg.Show();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ARTISClient.logOut(Program.TOKEN);
            txtUsername.Text = "";
            txtPassword.Text = "";
            lblUsername.Visible = true;
            lblPassword.Visible = true;
            txtUsername.Visible = true;
            txtPassword.Visible = true;
            btnLogIn.Visible = true;
            lblLogInError.Visible = false;
            this.Text = "ARTIS Administration System - Logged Out";
            ArtisMessage msg = new ArtisMessage("Logged Out");
            msg.Show();
        }
    }
}
