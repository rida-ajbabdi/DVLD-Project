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
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        private clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
        private clsPerson Person = new clsPerson();
        
        public frmNewLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            if(LocalDrivingLicenseApplicationID!=-1)
            {
                LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            }
        }
        private void _ResetApplicationInfo()
        {
            txtID.Text = "********";
            dtpApplicationDate.Value = DateTime.Now;
            cbLisenceClass.DataSource = clsLicenseClasse.GetLicenseClassesList();
            cbLisenceClass.DisplayMember = "ClassName";
            cbLisenceClass.ValueMember = "LicenseClassID";
            txtApplicationFees.Text = clsApplicationType.Find(clsApplicationType.enApplicationType.enNewLocalLicense).Fees.ToString();
            txtCreatedBy.Text = clsDVLDBusinessSettings.CurrentUser.UserName;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (LocalDrivingLicenseApplication != null && Person.ID != -1)
            {
                tbNewLocalDrivingLicenseApplication.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Please Selecte a _Person !", "Invalide _Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _LoadLocalDrivingLicenseApplicationInfo()
        {
            clsApplication Application = clsApplication.Find(LocalDrivingLicenseApplication.ApplicationID);
            ctrlFiltredPerson.LoadPersonInfo(Application.ApplicationPersonID);
            txtID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            cbLisenceClass.SelectedValue =  LocalDrivingLicenseApplication.LicenseClassID;
            dtpApplicationDate.Value = Application.ApplicationDate;
            txtApplicationFees.Text = Application.PaidFees.ToString();
            txtCreatedBy.Text = clsUser.Find(Application.CreatedByUserID).UserName;
        }
        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetApplicationInfo();
            if (LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show($"Local Driving License Is Not Found !", "Local Driving License Is Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID!=-1)
            {
                ctrlFiltredPerson.DisableFilter();
                _LoadLocalDrivingLicenseApplicationInfo();
                return;
            }

        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            clsApplication Application = clsApplication.Find(Person.ID, 1, (int)cbLisenceClass.SelectedValue);

            switch (LocalDrivingLicenseApplication.Mode)
            {
                case (clsLocalDrivingLicenseApplication.enMode.Add):
                    {
                        
                        if(Application == null || Application.ApplicationStatus == clsApplication.enStatus.Cancelled)
                        {
                            LocalDrivingLicenseApplication.LicenseClassID = (int)cbLisenceClass.SelectedValue;
                            if (LocalDrivingLicenseApplication.Save(Person.ID))
                            {
                                txtID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                                MessageBox.Show($"Save Sucessfully ", "Save Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show($"Save Fail ! , Please Try Again ", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        if (Application.ApplicationStatus == clsApplication.enStatus.New)
                        {
                            MessageBox.Show($"This _Person Has Already Application With Same Classe With ID = {Application.ApplicationID} , Please Selecte Another Application Class  !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Application.ApplicationStatus == clsApplication.enStatus.Completed)
                        {
                            MessageBox.Show($"Save Fail ! , The _Person Has Already A License With The Same License Classe , Please Choose Another Class !", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        break;
                    }
                case (clsLocalDrivingLicenseApplication.enMode.Update):
                    {        
                        if (Application == null || Application.ApplicationStatus == clsApplication.enStatus.Cancelled)
                        {
                            LocalDrivingLicenseApplication.LicenseClassID = (int)cbLisenceClass.SelectedValue;
                            if (LocalDrivingLicenseApplication.Save(Person.ID))
                            {
                                MessageBox.Show($"Save Sucessfully ", "Save Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show($"Save Fail ! , Please Try Again ", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        if (LocalDrivingLicenseApplication == null)
                        {
                            MessageBox.Show($"Local Driving License Is Not Found !", "Local Driving License Is Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (Application.ApplicationStatus == clsApplication.enStatus.New && LocalDrivingLicenseApplication.LicenseClassID != (int)cbLisenceClass.SelectedValue)
                        {
                            MessageBox.Show($"This Person Has Already Application With Same Classe With ID = {Application.ApplicationID} , Please Selecte Another Application Class  !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Application.ApplicationStatus == clsApplication.enStatus.Completed)
                        {
                            MessageBox.Show($"Save Fail ! , The Person Has Already A License With The Same License Classe , Please Choose Another Class !", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(LocalDrivingLicenseApplication.LicenseClassID == (int)cbLisenceClass.SelectedValue)
                        {
                            MessageBox.Show($"No changes detected. There is nothing to Save", "Save Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        break;

                    }
            }
        }

        private void ctrlFiltredPerson_OnPerson_Selector(clsPerson obj)
        {
            if(obj !=null)
                this.Person = obj;
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
