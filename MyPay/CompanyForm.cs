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
    public partial class CompanyForm : MaterialForm
    {
        private MyPay.Context.MyPayContext _context;

        public CompanyForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                _context = new Context.MyPayContext();
                _context.Company.Load();
                companyBindingSource.DataSource = _context.Company.Local;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        private void SaveItem()
        {
            try
            {
                this.Validate();
                companyBindingSource.EndEdit();
                _context.SaveChanges();

                //companyDataGridView.Refresh();
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
                companyBindingSource.RemoveCurrent();
                companyBindingSource.EndEdit();
                _context.SaveChanges();
            }
        }
    }
}