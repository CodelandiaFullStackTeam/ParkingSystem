namespace ParkingSystem.Forms
{
    partial class frmSection
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
            txtCapacity = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnAddSection = new Button();
            label1 = new Label();
            dgData = new DataGridView();
            cbFloor = new ComboBox();
            cbSectionCode = new ComboBox();
            label4 = new Label();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacity.Location = new Point(202, 195);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(182, 35);
            txtCapacity.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 198);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 13;
            label3.Text = "Capacity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 139);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 11;
            label2.Text = "Floor";
            // 
            // btnAddSection
            // 
            btnAddSection.BackColor = Color.SkyBlue;
            btnAddSection.FlatStyle = FlatStyle.Flat;
            btnAddSection.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSection.ForeColor = SystemColors.ButtonFace;
            btnAddSection.Location = new Point(64, 286);
            btnAddSection.Name = "btnAddSection";
            btnAddSection.Size = new Size(164, 71);
            btnAddSection.TabIndex = 10;
            btnAddSection.Text = "Add Section";
            btnAddSection.UseVisualStyleBackColor = false;
            btnAddSection.Click += btnAddSection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 48);
            label1.TabIndex = 9;
            label1.Text = "Sections";
            // 
            // dgData
            // 
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Location = new Point(39, 380);
            dgData.Name = "dgData";
            dgData.RowHeadersWidth = 51;
            dgData.RowTemplate.Height = 29;
            dgData.Size = new Size(802, 314);
            dgData.TabIndex = 8;
            // 
            // cbFloor
            // 
            cbFloor.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFloor.FormattingEnabled = true;
            cbFloor.Location = new Point(202, 136);
            cbFloor.Name = "cbFloor";
            cbFloor.Size = new Size(182, 36);
            cbFloor.TabIndex = 15;
            // 
            // cbSectionCode
            // 
            cbSectionCode.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbSectionCode.FormattingEnabled = true;
            cbSectionCode.Location = new Point(617, 136);
            cbSectionCode.Name = "cbSectionCode";
            cbSectionCode.Size = new Size(182, 36);
            cbSectionCode.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(454, 139);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 16;
            label4.Text = "SectionCode";
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.SkyBlue;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ButtonFace;
            btnMainMenu.Location = new Point(39, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(164, 37);
            btnMainMenu.TabIndex = 18;
            btnMainMenu.Text = "MainMenu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // frmSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 717);
            Controls.Add(btnMainMenu);
            Controls.Add(cbSectionCode);
            Controls.Add(label4);
            Controls.Add(cbFloor);
            Controls.Add(txtCapacity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAddSection);
            Controls.Add(label1);
            Controls.Add(dgData);
            Name = "frmSection";
            Text = "frmSection";
            Load += frmSection_Load;
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCapacity;
        private Label label3;
        private Label label2;
        private Button btnAddSection;
        private Label label1;
        private DataGridView dgData;
        private ComboBox cbFloor;
        private ComboBox cbSectionCode;
        private Label label4;
        private Button btnMainMenu;
    }
}