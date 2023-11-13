using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowFloor_Click(object sender, EventArgs e)
        {
            frmFloor frmFloor = new frmFloor();
            frmFloor.Show();
            this.Hide();
        }

        private void btnShowSection_Click(object sender, EventArgs e)
        {
            frmSection frmSection = new frmSection();
            frmSection.Show();
            this.Hide();
        }
    }
}
