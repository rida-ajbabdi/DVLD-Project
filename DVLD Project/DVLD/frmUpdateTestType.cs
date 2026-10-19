using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD
{
    public partial class frmUpdateTestType : Form
    {
        clsTestType TestType = new clsTestType();
        public frmUpdateTestType(clsTestType.enTestType ID)
        {
            InitializeComponent();
            TestType = clsTestType.Find(ID);
        }
        public void LoadTestTypeInfo()
        {
            txtID.Text = TestType.ID.ToString();
            txtTitle.Text = TestType.Title;
            txtDescription.Text = TestType.Description;
            txtFees.Text = TestType.Fees.ToString();
        }
        private void UpdateTestTypeInfo(clsTestType TestType)
        {
            TestType.Title = txtTitle.Text;
            TestType.Description = txtDescription.Text;
            decimal Fees = 0;
            if (decimal.TryParse(txtFees.Text, out Fees))
            {
                TestType.Fees = Fees;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TestType != null)
            {
                UpdateTestTypeInfo(TestType);
                if (TestType.Save())
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
        private bool IsValidateDescription()
        {
            return txtDescription.Text != "";
        }
        private void txDescription_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateTitle())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtDescription, "");
                ValidProvider.SetError(txtDescription, "Valid Title ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtDescription, "");
                ErrorProvider.SetError(txtDescription, "Invalid Title ! ");

            }
        }
        private bool IsValidateFees()
        {
            return double.TryParse(txtFees.Text, out _);
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
        private void TestTypeInfo_Changed(object sender, EventArgs e)
        {
            btnSave.Enabled = IsValidateFees() && IsValidateTitle() && IsValidateDescription();
        }
        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            LoadTestTypeInfo();
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
