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
    public partial class ArtisMessage : Form
    {
        public ArtisMessage()
        {
            InitializeComponent();
        }

        public ArtisMessage(String msg)
        {
            InitializeComponent();
            lblMessage.Text = msg;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
