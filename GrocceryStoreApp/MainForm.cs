using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrocceryStoreApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lbUserMoney.Text = $"{150.55} zł";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
