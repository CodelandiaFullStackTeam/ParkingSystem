using ParkingSystem.Models;
using ParkingSystem.Operations.Abstract;
using ParkingSystem.Operations.Concrete;
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
    public partial class frmFloor : Form
    {
        IFloorOperation _floorOperation = new FloorManager();
        public frmFloor()
        {
            InitializeComponent();
        }

        private void frmFloor_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            var data = _floorOperation.GetAll().Data;
            dgData.DataSource = data;
        }

        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            int floorNumber = int.Parse(txtFloorNumber.Text);
            int capacity = int.Parse(txtCapacity.Text);
            var floor = new Floor(floorNumber, capacity);
            var result = _floorOperation.Add(floor);

            if (result.Success)
            {
                BindGrid();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
