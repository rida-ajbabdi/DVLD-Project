using DVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
namespace DVLDBusinessLayer
{
    public partial class ctrlPersonInfo : UserControl
    {
        public event Action<clsPerson> OnPersonSelector = delegate { };
        protected virtual void PersonSelector(clsPerson Person)
        {
            OnPersonSelector(Person);
        }
        private clsPerson _Person;
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        void _ResetPersonInfo()
        {
            txtID.Text = "******";
            txtNationalNo.Text = "";
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            rbFemal.Checked = false;
            rbMale.Checked = false;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbCountry.DataSource = clsCountry.GetCountriesList();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.SelectedIndex = cbCountry.FindString("Morocco");
            pctrProfil.ImageLocation = null;
        }
        public void FillPersonInfo(clsPerson Person)
        {
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
            if (Person.ImagePath != "")
                pctrProfil.ImageLocation = Person.ImagePath;
        }
        public void LoadPersonInfo(int ID)
        {
            if (ID == -1)
            {
                _ResetPersonInfo();
              
            }
            _Person = DVLDBusinessLayer.clsPerson.Find(ID);
            if (_Person != null)
            {
                FillPersonInfo(_Person);     
            }
            else
            {
                _ResetPersonInfo();
                MessageBox.Show($"_Person With ID = {ID} Not Found , Please Enter a Valid One ", "_Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            OnPersonSelector(this._Person);
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = DVLDBusinessLayer.clsPerson.Find(NationalNo);
            if (_Person != null)
            {
                FillPersonInfo(_Person);
                
            }
            else
            {
                _ResetPersonInfo();
                MessageBox.Show($"_Person With National No = {NationalNo} Not Found , Please Enter a Valid One ", "_Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            OnPersonSelector(this._Person);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add___Edit_Form frm = new Add___Edit_Form(_Person.ID);
            frm.ShowDialog();
            LoadPersonInfo(_Person.ID);
        }

        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
}
