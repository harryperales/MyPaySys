using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MyPay
{
    public partial class MainForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        private CompanyForm _companyForm;
        private DepartmentForm _deptForm;
        private DesignationForm _desigForm;
        private EmployeeForm _empForm;

        public MainForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = string.Format("{0} - v{1}", AssemblyInfo.GetProduct(), AssemblyInfo.GetVersion());

            _companyForm = new CompanyForm();
            _deptForm = new DepartmentForm();
            _desigForm = new DesignationForm();
            _empForm = new EmployeeForm();

            materialSkinManager.AddFormToManage(_companyForm);
            materialSkinManager.AddFormToManage(_deptForm);
            materialSkinManager.AddFormToManage(_desigForm);
            materialSkinManager.AddFormToManage(_empForm);
        }

        #region Methods

        private void ShowDept()
        {
            try
            {
                lblStatus.Text = "Loading Departments...";
                pbrMain.Visible = true;
                Application.DoEvents();

                if (_deptForm.Visible)
                {
                    _deptForm.WindowState = FormWindowState.Normal;
                    _deptForm.BringToFront();
                }
                else
                    _deptForm.Show(this);
            }
            finally
            {
                pbrMain.Visible = false;
                lblStatus.Text = "Ready";
            }
        }

        private void ShowDesig()
        {
            try
            {
                lblStatus.Text = "Loading Designations...";
                pbrMain.Visible = true;
                Application.DoEvents();

                if (_desigForm.Visible)
                {
                    _desigForm.WindowState = FormWindowState.Normal;
                    _desigForm.BringToFront();
                }
                else
                    _desigForm.Show(this);
            }
            finally
            {
                pbrMain.Visible = false;
                lblStatus.Text = "Ready";
            }
        }

        private void ShowCompany()
        {
            try
            {
                lblStatus.Text = "Loading Companies...";
                pbrMain.Visible = true;
                Application.DoEvents();

                if (_companyForm.Visible)
                {
                    _companyForm.WindowState = FormWindowState.Normal;
                    _companyForm.BringToFront();
                }
                else
                    _companyForm.Show(this);
            }
            finally
            {
                pbrMain.Visible = false;
                lblStatus.Text = "Ready";
            }
        }

        private void ShowEmployee()
        {
            try
            {
                lblStatus.Text = "Loading Employees...";
                pbrMain.Visible = true;
                Application.DoEvents();

                if (_empForm.Visible)
                {
                    _empForm.WindowState = FormWindowState.Normal;
                    _empForm.BringToFront();
                }
                else
                    _empForm.Show(this);
            }
            finally
            {
                pbrMain.Visible = false;
                lblStatus.Text = "Ready";
            }
        }

        private void CloseForm()
        {
            Close();
        }

        #endregion Methods

        #region Themes

        private void ChangeTheme()
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ?
                MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private int colorSchemeIndex;

        private void ChangeAccentColor()
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2) colorSchemeIndex = 0;

            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
            }
        }

        #endregion Themes

        #region Events

        private void btnTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ChangeAccentColor();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            ShowDept();
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            ShowDesig();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            ShowCompany();
        }

        #endregion Events
    }
}