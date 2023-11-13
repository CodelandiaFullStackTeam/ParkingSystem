namespace ParkingSystem.Forms
{
    partial class frmFloor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgData = new DataGridView();
            label1 = new Label();
            btnAddFloor = new Button();
            label2 = new Label();
            txtFloorNumber = new TextBox();
            txtCapacity = new TextBox();
            label3 = new Label();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // dgData
            // 
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Location = new Point(12, 343);
            dgData.Name = "dgData";
            dgData.RowHeadersWidth = 51;
            dgData.RowTemplate.Height = 29;
            dgData.Size = new Size(802, 314);
            dgData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 48);
            label1.TabIndex = 1;
            label1.Text = "Floors";
            // 
            // btnAddFloor
            // 
            btnAddFloor.BackColor = Color.SkyBlue;
            btnAddFloor.FlatStyle = FlatStyle.Flat;
            btnAddFloor.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFloor.ForeColor = SystemColors.ButtonFace;
            btnAddFloor.Location = new Point(12, 233);
            btnAddFloor.Name = "btnAddFloor";
            btnAddFloor.Size = new Size(164, 71);
            btnAddFloor.TabIndex = 2;
            btnAddFloor.Text = "Add Floor";
            btnAddFloor.UseVisualStyleBackColor = false;
            btnAddFloor.Click += btnAddFloor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 4;
            label2.Text = "FloorNumber";
            // 
            // txtFloorNumber
            // 
            txtFloorNumber.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFloorNumber.Location = new Point(175, 92);
            txtFloorNumber.Name = "txtFloorNumber";
            txtFloorNumber.Size = new Size(182, 35);
            txtFloorNumber.TabIndex = 5;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacity.Location = new Point(175, 151);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(182, 35);
            txtCapacity.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 6;
            label3.Text = "Capacity";
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.SkyBlue;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonFace;
            btnMainMenu.Location = new Point(12, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(164, 37);
            btnMainMenu.TabIndex = 8;
            btnMainMenu.Text = "MainMenu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // frmFloor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 669);
            Controls.Add(btnMainMenu);
            Controls.Add(txtCapacity);
            Controls.Add(label3);
            Controls.Add(txtFloorNumber);
            Controls.Add(label2);
            Controls.Add(btnAddFloor);
            Controls.Add(label1);
            Controls.Add(dgData);
            Name = "frmFloor";
            Text = "frmFloor";
            Load += frmFloor_Load;
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgData;
        private Label label1;
        private Button btnAddFloor;
        private Label label2;
        private TextBox txtFloorNumber;
        private TextBox txtCapacity;
        private Label label3;
        private Button btnMainMenu;
    }
}