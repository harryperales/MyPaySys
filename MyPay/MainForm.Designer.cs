namespace MyPay
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAttendance = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDepartment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDesignation = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCompany = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTheme = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnColor = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.pbrMain = new MaterialSkin.Controls.MaterialProgressBar();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Depth = 0;
            this.btnEmployee.Image = global::MyPay.Properties.Resources.employee;
            this.btnEmployee.Location = new System.Drawing.Point(12, 89);
            this.btnEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Primary = true;
            this.btnEmployee.Size = new System.Drawing.Size(180, 97);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Depth = 0;
            this.btnAttendance.Location = new System.Drawing.Point(198, 89);
            this.btnAttendance.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Primary = true;
            this.btnAttendance.Size = new System.Drawing.Size(180, 97);
            this.btnAttendance.TabIndex = 0;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Depth = 0;
            this.btnDepartment.Location = new System.Drawing.Point(384, 89);
            this.btnDepartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Primary = true;
            this.btnDepartment.Size = new System.Drawing.Size(180, 97);
            this.btnDepartment.TabIndex = 0;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnDesignation
            // 
            this.btnDesignation.Depth = 0;
            this.btnDesignation.Location = new System.Drawing.Point(570, 89);
            this.btnDesignation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDesignation.Name = "btnDesignation";
            this.btnDesignation.Primary = true;
            this.btnDesignation.Size = new System.Drawing.Size(180, 97);
            this.btnDesignation.TabIndex = 0;
            this.btnDesignation.Text = "Designation";
            this.btnDesignation.UseVisualStyleBackColor = true;
            this.btnDesignation.Click += new System.EventHandler(this.btnDesignation_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Depth = 0;
            this.btnCompany.Location = new System.Drawing.Point(12, 191);
            this.btnCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Primary = true;
            this.btnCompany.Size = new System.Drawing.Size(180, 97);
            this.btnCompany.TabIndex = 0;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Depth = 0;
            this.btnSettings.Location = new System.Drawing.Point(198, 191);
            this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Primary = true;
            this.btnSettings.Size = new System.Drawing.Size(180, 97);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnTheme
            // 
            this.btnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTheme.AutoSize = true;
            this.btnTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTheme.Depth = 0;
            this.btnTheme.Location = new System.Drawing.Point(702, 26);
            this.btnTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Primary = false;
            this.btnTheme.Size = new System.Drawing.Size(58, 36);
            this.btnTheme.TabIndex = 2;
            this.btnTheme.Text = "Theme";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.AutoSize = true;
            this.btnColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnColor.Depth = 0;
            this.btnColor.Location = new System.Drawing.Point(638, 26);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnColor.Name = "btnColor";
            this.btnColor.Primary = false;
            this.btnColor.Size = new System.Drawing.Size(56, 36);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(8, 512);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready";
            // 
            // pbrMain
            // 
            this.pbrMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrMain.Depth = 0;
            this.pbrMain.Location = new System.Drawing.Point(650, 523);
            this.pbrMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbrMain.Name = "pbrMain";
            this.pbrMain.Size = new System.Drawing.Size(100, 5);
            this.pbrMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbrMain.TabIndex = 4;
            this.pbrMain.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(762, 540);
            this.Controls.Add(this.pbrMain);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnDesignation);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnEmployee);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyPay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton btnAttendance;
        private MaterialSkin.Controls.MaterialRaisedButton btnDepartment;
        private MaterialSkin.Controls.MaterialRaisedButton btnDesignation;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompany;
        private MaterialSkin.Controls.MaterialRaisedButton btnSettings;
        private MaterialSkin.Controls.MaterialFlatButton btnTheme;
        private MaterialSkin.Controls.MaterialFlatButton btnColor;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialProgressBar pbrMain;
    }
}

