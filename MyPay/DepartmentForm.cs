using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPay
{
    public partial class DepartmentForm : MaterialForm
    {
        private MyPay.Context.MyPayContext _context;
        //private MaterialSkinManager materialSkinManager;

        public DepartmentForm()
        {
            InitializeComponent();

            //materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                _context = new Context.MyPayContext();
                _context.Department.Load();
                departmentBindingSource.DataSource = _context.Department.Local;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void SaveItem()
        {
            try
            {
                this.Validate();
                departmentBindingSource.EndEdit();
                _context.SaveChanges();

                //departmentDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                return;
            }
            else
            {
                base.OnFormClosing(e);
                if (_context != null)
                    _context.Dispose();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                departmentBindingSource.RemoveCurrent();
                departmentBindingSource.EndEdit();
                _context.SaveChanges();
            }
        }
    }
}