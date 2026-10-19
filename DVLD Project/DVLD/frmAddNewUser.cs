using DVLDBusinessLayer;
using Guna.UI2.WinForms;
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
    
    public partial class frmAddNewUser : Form
    {
        public clsUser User = new clsUser();
        public frmAddNewUser(int UserID)
        {
            InitializeComponent();
            if( UserID!= -1 )
            {
                User = clsUser.Find(UserID);
                if(User != null )
                {
                    ctrlFiltredPerson.DisableFilter();
                    ctrlFiltredPerson.LoadPersonInfo(User.PersonID);
                    FillUserInfo(User);
                }
            }
        }

        
        private bool IsValidatePassword(ref string Message)
        {
            if (txtPassword.Text.Length < 8)
            {
                Message = "At least 8 characters long";
                return false;
            }
            if (!txtPassword.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                Message = "Contains at least one special character (!@#$%^&* etc.)";
                return false;
            }
            if (!txtPassword.Text.Any(char.IsDigit))
            {
                Message = "Contains at least one number (0–9) ";
                return false;
            }
            if (!txtPassword.Text.Any(char.IsUpper))
            {
                Message = "Contains at least one uppercase letter (A–Z)";
                return false;
            }
            if (!txtPassword.Text.Any(char.IsLower))
            {
                Message = "Contains at least one lowercase letter (a–z)  \r\n";
                return false;
            }
            return true;
        }
        private bool IsValidateConfirmPassoword()
        {
            return txtPassword.Text == txtConfirmPassword.Text && txtConfirmPassword.Text != "";
        }
        private bool IsValidateUserName()
        {
            return txtUserName.Text != "";
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateUserName())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtUserName, "");
                ValidProvider.SetError(txtUserName, "Invalid UserName ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtUserName, "");
                ErrorProvider.SetError(txtUserName, "Valid UserName ");
            }
        }

        
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string Message = "";
            if (IsValidatePassword(ref Message))
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtPassword, "");
                ValidProvider.SetError(txtPassword, "Valid Choice ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtPassword, "");
                ErrorProvider.SetError(txtPassword, Message);
            }
        }

        private void UserInfo_Changed(object sender, EventArgs e)
        {
            string Message = "";
            if (User.Mode == clsUser.enMode.Add)
            {
                if (User.PersonID == -1 || clsUser.IsExistByPersonID(User.PersonID))
                {
                    btnSave.Enabled = false;
                    return;
                }
            }
            if (IsValidateUserName() && IsValidatePassword(ref Message) && IsValidateConfirmPassoword())
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
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

        
        void LoadUserInfo(clsUser User)
        {
            User.UserName = txtUserName.Text;
            User.SetPassword(txtPassword.Text) ;
            User.IsActive = chkIsActive.Checked;
        }
        void FillUserInfo(clsUser User)
        {
            txtUserName.Text = User.UserName;
            chkIsActive.Checked = User.IsActive;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (User != null)
            {
                LoadUserInfo(User);
                if (User.Save())
                {
                    txtUserID.Text = User.ID.ToString();
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

        
        
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ctrlFiltredPerson_OnPerson_Selector(clsPerson obj)
        {
            string Message = "";
            if (User.Mode == clsUser.enMode.Add)
            {
                if (obj == null || clsUser.IsExistByPersonID(obj.ID))
                {
                    btnSave.Enabled = false;
                    return;
                }
                User.PersonID = obj.ID;
            }
            if (IsValidateUserName() && IsValidatePassword(ref Message) && IsValidateConfirmPassoword())
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }





        private void frmAddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (User != null && User.PersonID != -1)
            {
                switch (User.Mode)
                {
                    case clsUser.enMode.Add:
                        {
                            if (!clsUser.IsExistByPersonID(ctrlFiltredPerson.Person.ID))
                            {
                                User.PersonID = ctrlFiltredPerson.Person.ID;
                                tbAddNewUser.SelectedIndex = 1;
                            }
                            else
                            {
                                MessageBox.Show("This _Person Is Already Linked With Another User !", "Invalide _Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    case clsUser.enMode.Update:
                        {

                            tbAddNewUser.SelectedIndex = 1;
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Please Selecte a _Person !", "Invalide _Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
