using MaterialSkin.Controls;
using MyPay.Models;
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
    public partial class EmployeeForm : MaterialForm
    {
        private Context.MyPayContext _context;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                _context = new Context.MyPayContext();

                _context.Department.Load();
                _context.Designation.Load();
                _context.Company.Load();
                _context.Employee.Load();

                departmentBindingSource.DataSource = _context.Department.Local;
                designationBindingSource.DataSource = _context.Designation.Local;
                companyBindingSource.DataSource = _context.Company.Local;
                reportingBindingSource.DataSource = _context.Employee.Local;
                employeeBindingSource.DataSource = _context.Employee.Local;

                // Use ValueChanged to decide if the value should be displayed:
                dtpEmpDor.ValueChanged += (s, ev) => { dtpEmpDor.CustomFormat = (dtpEmpDor.Checked && dtpEmpDor.Value != dtpEmpDor.MinDate) ? "dd/MM/yyyy" : " "; };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void SaveItem()
        {
            try
            {
                ((Employee)employeeBindingSource.Current).Dor = (dtpEmpDor.Checked /*&& dtpEmpDor.Value != dtpEmpDor.MinDate*/) ? (DateTime?)dtpEmpDor.Value : null;

                this.Validate();
                employeeBindingSource.EndEdit();
                _context.SaveChanges();

                employeeDataGridView.Refresh();
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
                employeeBindingSource.RemoveCurrent();
                employeeBindingSource.EndEdit();
                _context.SaveChanges();
            }
        }
    }
}