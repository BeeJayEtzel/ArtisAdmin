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
    public partial class ArtisDialog : Form
    {
        public ArtisDialog()
        {
            InitializeComponent();
        }

        public ArtisDialog(String msg)
        {
            InitializeComponent();
            lblMessage.Text = msg;
        }
    }
}
