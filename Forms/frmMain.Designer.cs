namespace ParkingSystem.Forms
{
    partial class frmMain
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
            btnShowFloor = new Button();
            btnShowSection = new Button();
            SuspendLayout();
            // 
            // btnShowFloor
            // 
            btnShowFloor.BackColor = Color.SkyBlue;
            btnShowFloor.FlatStyle = FlatStyle.Flat;
            btnShowFloor.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowFloor.ForeColor = SystemColors.ButtonFace;
            btnShowFloor.Location = new Point(35, 30);
            btnShowFloor.Name = "btnShowFloor";
            btnShowFloor.Size = new Size(164, 71);
            btnShowFloor.TabIndex = 3;
            btnShowFloor.Text = "FloorMenu";
            btnShowFloor.UseVisualStyleBackColor = false;
            btnShowFloor.Click += btnShowFloor_Click;
            // 
            // btnShowSection
            // 
            btnShowSection.BackColor = Color.SkyBlue;
            btnShowSection.FlatStyle = FlatStyle.Flat;
            btnShowSection.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowSection.ForeColor = SystemColors.ButtonFace;
            btnShowSection.Location = new Point(242, 30);
            btnShowSection.Name = "btnShowSection";
            btnShowSection.Size = new Size(164, 71);
            btnShowSection.TabIndex = 4;
            btnShowSection.Text = "SectionMenu";
            btnShowSection.UseVisualStyleBackColor = false;
            btnShowSection.Click += btnShowSection_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowSection);
            Controls.Add(btnShowFloor);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowFloor;
        private Button btnShowSection;
    }
}