using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using static DVLDBusinessLayer.clsPerson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DVLDBusinessLayer;
namespace DVLDBusinessLayer
{
    public partial class ctrlPerson : UserControl
    {
        private clsPerson _Person = new clsPerson();
        public event Action OnValidatingInformation;
        
        protected virtual void ValidatingInformation()
        {
            Action hundler = OnValidatingInformation;
            if (hundler != null)
            {
                hundler();
            }

        }
        public bool IsValidateInformation { get; private set; } = false;
        void _ResetPersonInfo()
        {
            txtID.Text = "******";
            txtNationalNo.Text = "";
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            rbFemal.Checked = false;
            rbMale.Checked = false;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbCountry.DataSource = clsCountry.GetCountriesList();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.SelectedIndex = cbCountry.FindString("Morocco");
            // Hundel Default Image Per Gender
            pctrProfil.ImageLocation = null;
        }
        public void FillPersonInfo(clsPerson Person)
        {
            if (Person.ImagePath != "")
                pctrProfil.ImageLocation = Person.ImagePath;
            txtID.Text = Person.ID.ToString();
            txtNationalNo.Text = Person.NationalNo;
            txtFirstName.Text = Person.FirstName;
            txtSecondName.Text = Person.SecondName;
            txtThirdName.Text = Person.ThirdName;
            txtLastName.Text = Person.LastName;
            dtpDateOfBirth.Value = Person.DateOfBirth;
            if (Person.Gender == clsPerson.enGender.Femel)
                rbFemal.Checked = true;
            else
                rbMale.Checked = true;
            txtAddress.Text = Person.Address;
            txtPhone.Text = Person.Phone;
            txtEmail.Text = Person.Email;
            cbCountry.DataSource = clsCountry.GetCountriesList();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.SelectedIndex = cbCountry.FindString(Person.Nationality);
            chkIagreeCondtions.Checked = true;

        }
        public void UpdatePersonInfo(clsPerson Person)
        {
            Person.NationalNo = txtNationalNo.Text;
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecondName.Text;
            Person.ThirdName = txtThirdName.Text;
            Person.LastName = txtLastName.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;
            Person.Gender = (rbFemal.Checked) ? enGender.Femel : enGender.Male;
            Person.Address = txtAddress.Text;
            Person.Phone = txtPhone.Text;
            Person.Email = txtEmail.Text;
            Person.Nationality = cbCountry.Text;
            Person.OldImagePath = Person.ImagePath;
            Person.ImagePath = pctrProfil.ImageLocation ?? "";
        }
        public clsPerson LoadPersonInfo(int ID)
        {
            if(ID == -1)
            {
                _ResetPersonInfo();
                return new clsPerson();
            }
            _Person = DVLDBusinessLayer.clsPerson.Find(ID);
            if (_Person!=null)
            {
                FillPersonInfo (_Person);
                return _Person;
            }
            else
            {
                MessageBox.Show($"_Person With ID = {ID} Not Found , Please Enter a Valid One ", "_Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public ctrlPerson()
        {
            InitializeComponent();
        }



        /////////////////////////////////////////////////////////////////////




        private bool IsValidateFirstName()
        {
            return txtFirstName.Text != "";
        }
        private bool IsValidateAddress()
        {
            return txtAddress.Text != "";
        }
        private bool IsValidateLastName()
        {
            return txtLastName.Text != "";
        }
        private bool IsValidateEmail()
        {
            if (txtEmail.Text == "")
                return true;
            string Email = txtEmail.Text.Trim();
            string[] AllowedDomains = new string[]
            {
                  "@gmail.com",    // Google
                  "@yahoo.com",    // Yahoo
                  "@hotmail.com",  // Microsoft
                  "@outlook.com",  // Microsoft Outlook
                  "@live.com",     // Microsoft Live
                  "@icloud.com",   // Apple iCloud
                  "@aol.com",      // AOL
                  "@mail.com",     // Mail.com
                  "@protonmail.com", // ProtonMail
                  "@gmx.com",      // GMX
                  "@zoho.com",     // Zoho Mail
                  "@yandex.com",   // Yandex
                  "@msn.com",      // MSN
                  "@pm.me",        // ProtonMail short
                  "@me.com",       // Apple MobileMe
                  "@inbox.com",    // Inbox
            };
            bool IsValid = AllowedDomains.Any(domain => Email.EndsWith(domain));
            return IsValid;
        }
        private bool IsValidatePhone()
        {
            return txtPhone.Text.All(char.IsDigit) && txtPhone.Text != "";
        }

        private bool IsValidateGender()
        {
            return (rbMale.Checked || rbFemal.Checked);
        }
        private bool IsValidateIagreeConditions()
        {
            return chkIagreeCondtions.Checked;
        }
        private bool IsValidateNationalNo()
        {
            if (txtNationalNo.Text != "" && txtNationalNo.Text == _Person.NationalNo)
                return true;
            if(!clsPerson.IsExist(txtNationalNo.Text) && txtNationalNo.Text != "")
                return true;
            return false;
        }
        private void UpdateProgressBar()
        {
            byte Value = 0;
            if (true)
                Value += 10;
            if (IsValidateFirstName())
                Value += 10;
            if (IsValidateLastName())
                Value += 10;
            if (IsValidateGender())
                Value += 10;
            if (IsValidatePhone())
                Value += 10;
            if (IsValidateAddress())
                Value += 10;
            if (IsValidateEmail())
                Value += 10;
            if (IsValidateNationalNo())
                Value += 10;
            if (IsValidateIagreeConditions())
                Value += 10;
            if (IsValidateImage())
                Value += 10;
            if (Value == 100)
                IsValidateInformation = true;
            else
                IsValidateInformation = false;
            CircleProgressBar.Value = Value;
            lblProgressBarValue.Text = Value.ToString() + "%";
            ValidatingInformation();
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateFirstName())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtFirstName, "");
                ValidProvider.SetError(txtFirstName, "Valid UserName ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtFirstName, "");
                ErrorProvider.SetError(txtFirstName, "Invalid UserName ! ");

            }
        }
        private void chkIagreeCondition_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateIagreeConditions())
            {
                e.Cancel = false;
                ErrorProvider.SetError(chkIagreeCondtions, "");
                ValidProvider.SetError(chkIagreeCondtions, "I Agree All Conditions ...");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(chkIagreeCondtions, "");
                ErrorProvider.SetError(chkIagreeCondtions, "You Should Agree All Conditions ! ");

            }
        }



        /// ////////////////////////////////////////////////////////////////////////


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }



        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }


        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateLastName())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtLastName, "");
                ValidProvider.SetError(txtLastName, "Valid Last Name ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtLastName, "");
                ErrorProvider.SetError(txtLastName, "Invalid Last Name ! ");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidatePhone())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtPhone, "");
                ValidProvider.SetError(txtPhone, "Valid Phone ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtPhone, "");
                ErrorProvider.SetError(txtPhone, "Invalid Number Phone ! ");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateEmail())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtEmail, "");
                ValidProvider.SetError(txtEmail, "Valid Email ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtEmail, "");
                ErrorProvider.SetError(txtEmail, "Invalid Email ! , Email Must Be End With @gmail.com ");
            }
        }

        private void gbGender_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateGender())
            {
                e.Cancel = false;
                ErrorProvider.SetError(gbGender, "");
                ValidProvider.SetError(gbGender, "Valid Choice ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(gbGender, "");
                ErrorProvider.SetError(gbGender, "Invalid Choice ! ");
            }
        }

        

        
        private bool IsValidateImage()
        {
            return pctrProfil.ImageLocation != null;
        }
        private void pctrProfil_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateImage())
            {
                e.Cancel = false;
                ErrorProvider.SetError(btnEditImage, "");
                ValidProvider.SetError(btnEditImage, "Valid Choice ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(btnEditImage, "");
                ErrorProvider.SetError(btnEditImage, "Invalid Choice ! ");
            }
        }



        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void rbFemal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }
 
        private void UpdateImage()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                pctrProfil.ImageLocation = openfiledialog.FileName;
            }
        }
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            UpdateImage();
            UpdateProgressBar();
            
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateAddress())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtAddress, "");
                ValidProvider.SetError(txtAddress, "Valid Address ! ");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtAddress, "");
                ErrorProvider.SetError(txtAddress, "Invalid Address ! ");
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void chkIagreeCondtions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidateNationalNo())
            {
                e.Cancel = false;
                ErrorProvider.SetError(txtNationalNo, "");
                ValidProvider.SetError(txtNationalNo, "Valid National No");
            }
            else
            {
                e.Cancel = true;
                ValidProvider.SetError(txtNationalNo, "");
                ErrorProvider.SetError(txtNationalNo, "Invalid National No  , This No Is Already Exist !! ");
            }
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }
    }
    
}
