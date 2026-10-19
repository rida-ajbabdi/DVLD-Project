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
    public partial class frmChangePassword : Form
    {
        clsUser User = new clsUser();
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            User.ID = UserID;
        }
        private bool IsValidateCurrentPassword()
        {
            return User.IsValidatePassword(txtCurrentPassword.Text);
        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            
            if (IsValidateCurrentPassword())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtCurrentPassword, "");
                ValidProvider.SetError(txtCurrentPassword, "Valide Current Passowrd ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtCurrentPassword, "");
                ErrorProvider.SetError(txtCurrentPassword, "Valide Current Passowrd ! ");
            }
        }
        private void UserInfo_Changed(object sender, EventArgs e)
        {
            string Message = "";
            if(IsValidateCurrentPassword() && IsValidateNewPassword(ref Message) && IsValidateConfirmPassoword())
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private bool IsValidateNewPassword(ref string Message)
        {
            if (txtNewPassword.Text.Length < 8)
            {
                Message = "At least 8 characters long";
                return false;
            }
            if (!txtNewPassword.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                Message = "Contains at least one special character (!@#$%^&* etc.)";
                return false;
            }
            if (!txtNewPassword.Text.Any(char.IsDigit))
            {
                Message = "Contains at least one number (0–9) ";
                return false;
            }
            if (!txtNewPassword.Text.Any(char.IsUpper))
            {
                Message = "Contains at least one uppercase letter (A–Z)";
                return false;
            }
            if (!txtNewPassword.Text.Any(char.IsLower))
            {
                Message = "Contains at least one lowercase letter (a–z)  \r\n";
                return false;
            }
            if(txtNewPassword.Text == txtCurrentPassword.Text)
            {
                Message = "The New Password Should Different To Current Passowrd  \r\n";
                return false;
            }
            return true;
        }
        private bool IsValidateConfirmPassoword()
        {
            return txtNewPassword.Text == txtConfirmPassword.Text && txtConfirmPassword.Text != "";
        }


        
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            string Message = "";
            if (IsValidateNewPassword(ref Message))
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtNewPassword, "");
                ValidProvider.SetError(txtNewPassword, "Valid Choice ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtNewPassword, "");
                ErrorProvider.SetError(txtNewPassword, Message);
            }
        }

       
        
        private void txtConfirmPassoword_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateConfirmPassoword())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtConfirmPassword, "");
                ValidProvider.SetError(txtConfirmPassword, "Valid Choice ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtConfirmPassword, "");
                ErrorProvider.SetError(txtConfirmPassword, " Passwords Do Not Match !");
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlUserInfo.LoadUserInfo(User.ID);
            User = ctrlUserInfo.User;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (User != null)
            {
                User.SetPassword(txtNewPassword.Text);
                if (User.Save())
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
                MessageBox.Show($"User Not Found ! , Please Try Again ", "Save Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
