using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationType ApplicationType = new clsApplicationType();
        public frmUpdateApplicationType(clsApplicationType.enApplicationType ID)
        {
            InitializeComponent();
            ApplicationType = clsApplicationType.Find(ID);
        }
        public void LoadApplicationTypeInfo()
        {
            txtID.Text = ApplicationType.ID.ToString();
            txtTitle.Text = ApplicationType.Title;
            txtFees.Text = ApplicationType.Fees.ToString();
        }
        private void UpdateApplicationTypeInfo(clsApplicationType ApplicationType)
        {
            ApplicationType.Title = txtTitle.Text;
            decimal Fees = 0;
            if(decimal.TryParse(txtFees.Text , out Fees))
            {
                ApplicationType.Fees = Fees;
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ApplicationType != null)
            {
                UpdateApplicationTypeInfo(ApplicationType);
                if (ApplicationType.Save())
                {
                    MessageBox.Show($"Save Sucessfully ", "Save Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Save Faild ! , Please Try Again ", "Save Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"_Person Not Found ! , Please Try Again ", "Save Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidateTitle()
        {
            return txtTitle.Text != "";
        }
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateTitle())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtTitle, "");
                ValidProvider.SetError(txtTitle, "Valid Title ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtTitle, "");
                ErrorProvider.SetError(txtTitle, "Invalid Title ! ");

            }
        }
        private bool IsValidateFees()
        {
            return double.TryParse(txtFees.Text , out _);
        }
        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateFees())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtFees, "");
                ValidProvider.SetError(txtFees, "Valid Fees ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtFees, "");
                ErrorProvider.SetError(txtFees, "Invalid Fees ! ");

            }
        }
        private void ApplicationTypeInfo_Changed(object sender, EventArgs e)
        {
            
            btnSave.Enabled = IsValidateFees() && IsValidateTitle();
        }
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            LoadApplicationTypeInfo();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            char UserInput = e.KeyChar;
            if (!int.TryParse(UserInput.ToString(), out _) && UserInput != 46 && UserInput != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
