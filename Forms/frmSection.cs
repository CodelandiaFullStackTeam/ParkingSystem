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
    public partial class frmSection : Form
    {
        ISectionOperation _sectionOperation = new SectionManager();
        IFloorOperation _floorOperation = new FloorManager();
        public frmSection()
        {
            InitializeComponent();
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindComboBoxes();
        }

        private void BindComboBoxes()
        {
            #region Floors

            var floorData = _floorOperation.GetAll().Data;
            cbFloor.DataSource = floorData;
            cbFloor.DisplayMember = "FloorCode";
            cbFloor.ValueMember = "ID";

            #endregion

            #region Sections

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            cbSectionCode.DataSource = alphabet.ToCharArray();

            #endregion
        }

        private void BindGrid()
        {
            var result = _sectionOperation.GetSectionDetails();
            if (result.Success)
            {
                dgData.DataSource = result.Data;
            }
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            try
            {
                AddSection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddSection()
        {
            int floorId = int.Parse(cbFloor.SelectedValue.ToString());
            string sectionCode = cbSectionCode.SelectedValue.ToString();
            int capacity = int.Parse(txtCapacity.Text);
            Section section = new Section(floorId, capacity, sectionCode);
            var result = _sectionOperation.Add(section);

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
