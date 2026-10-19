using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDBusinessLayer.clsApplication;
namespace DVLD
{
    public partial class Form1 : Form
    {
        private int LastTabIndex = 1;
        void _RefreshListPeople()
        {
            dgvListPeople.DataSource = clsPerson.GetPeopleList();
        }
        void _RefreshListPeople(string ColumnName, string Value)
        {
            dgvListPeople.DataSource = clsPerson.GetFilteredPeopleList(ColumnName, Value);
        }
        void _RefreshListPeople(int PersonID)
        {
            dgvListPeople.DataSource = clsPerson.GetFilteredPeopleList(PersonID);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbDVLDMenu.SelectedIndex = 1;
            _RefreshListPeople();
        }

        private void FilterPerson_Changed(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterPeopleBy.SelectedItem.ToString().Replace(" ", "");
            FilterColumn = FilterColumn.Replace("Nationality", "CountryName");
            if (FilterColumn == "None")
            {
                txtPeopleFilter.Visible = false;
                _RefreshListPeople();
                return;
            }
            txtPeopleFilter.Visible = true;
            txtPeopleFilter.PlaceholderText = "Please Enter " + cbFilterPeopleBy.SelectedItem.ToString();
            if (FilterColumn == "PersonID")
            {
                int ID;
                if (int.TryParse(txtPeopleFilter.Text, out ID))
                {
                    _RefreshListPeople(ID);
                }

                return;
            }
            _RefreshListPeople(FilterColumn, txtPeopleFilter.Text);
            return;
        }

        private void cmsiEditPerson_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListPeople.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                Add___Edit_Form frm = new Add___Edit_Form(ID);
                frm.ShowDialog();
                _RefreshListPeople();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsiShowPersonDetails_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListPeople.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                PersonDetails frm = new PersonDetails(ID);
                frm.ShowDialog();
                _RefreshListPeople();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsiAddNewPerson_Click(object sender, EventArgs e)
        {
            int ID = -1;
            Add___Edit_Form frm = new Add___Edit_Form(ID);
            frm.ShowDialog();
            _RefreshListPeople();
        }

        private void cmsiDeletePerson_Click(object sender, EventArgs e)
        {
            int ID = -1;
            DataGridViewRow SelectedPerson = dgvListPeople.SelectedRows[0];
            if (int.TryParse(SelectedPerson.Cells[0].Value.ToString(), out ID))
            {
                if (MessageBox.Show("Are You Sure Do You Want To Delte This _Person ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsPerson.Delete(ID, SelectedPerson.Cells["ImagePath"].Value.ToString()))
                    {
                        MessageBox.Show("_Person Deleted Sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshListPeople();
                    }
                    else
                    {
                        MessageBox.Show("_Person Deleted Fail", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            int ID = -1;
            Add___Edit_Form frm = new Add___Edit_Form(ID);
            frm.ShowDialog();
            _RefreshListPeople();
        }


        private void txtFilterPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterPeopleBy.SelectedItem.ToString() == "_Person ID")
            {
                char UserInput = e.KeyChar;
                if (!int.TryParse(UserInput.ToString(), out _) && UserInput != 46 && UserInput != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private void cmsiSendEmailToPerson_Click(object sender, EventArgs e)
        {

        }

        private void cmsiPhoneCallPerson_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////////////////
        ///
        void _RefreshListUsers()
        {
            dgvListUsers.DataSource = clsUser.GetUsersList();
        }
        void _RefreshListUsers(bool IsActive)
        {
            dgvListUsers.DataSource = clsUser.GetFilteredUsersList(IsActive);
        }
        void _RefreshListUsers(string ColumnName, string Value)
        {
            dgvListUsers.DataSource = clsUser.GetFilteredUsersList(ColumnName, Value);
        }
        void _RefreshListUsersByPersonID(int PersonID)
        {
            dgvListUsers.DataSource = clsUser.GetFilteredUsersListByPersonID(PersonID);
        }

        void _RefreshListUsersByUserID(int UserID)
        {
            dgvListUsers.DataSource = clsUser.GetFilteredUsersListByUserID(UserID);
        }
        private void FilterUser_Changed(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterUsersBy.SelectedItem.ToString().Replace(" ", "");
            switch (FilterColumn)
            {
                case ("None"):
                    {
                        txtUsersFilter.Visible = false;
                        cbIsActive.Visible = false;
                        _RefreshListUsers();
                        break;
                    }
                case ("IsActive"):
                    {
                        txtUsersFilter.Visible = false;
                        cbIsActive.Visible = true;

                        break;
                    }

                case ("PersonID"):
                    {
                        txtUsersFilter.PlaceholderText = "Please Enter _Person ID";
                        txtUsersFilter.Visible = true;
                        cbIsActive.Visible = false;
                        int ID;
                        if (int.TryParse(txtUsersFilter.Text, out ID))
                        {
                            _RefreshListUsersByPersonID(ID);
                            return;
                        }

                        break;
                    }
                case ("UserID"):
                    {
                        txtUsersFilter.PlaceholderText = "Please Enter User ID";
                        txtUsersFilter.Visible = true;
                        cbIsActive.Visible = false;
                        int ID;
                        if (int.TryParse(txtUsersFilter.Text, out ID))
                        {
                            _RefreshListUsersByUserID(ID);
                        }

                        break;
                    }
                case ("FullName"):
                    {
                        txtUsersFilter.PlaceholderText = "Please Enter Full Name";
                        txtUsersFilter.Visible = true;
                        cbIsActive.Visible = false;
                        _RefreshListUsers("FirstName + SecondName + ThirdName + LastName", txtUsersFilter.Text);

                        break;
                    }
                case ("UserName"):
                    {
                        txtUsersFilter.PlaceholderText = "Please Enter User ID";
                        txtUsersFilter.Visible = true;
                        cbIsActive.Visible = false;
                        _RefreshListUsers("UserName", txtUsersFilter.Text);
                        break;
                    }
            }

        }



        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int UserID = -1;
            frmAddNewUser frm = new frmAddNewUser(UserID);
            frm.ShowDialog();
            _RefreshListUsers();
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtFilterUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUsersBy.SelectedItem.ToString() == "User ID")
            {
                char UserInput = e.KeyChar;
                if (!int.TryParse(UserInput.ToString(), out _) && UserInput != 46 && UserInput != 8)
                {
                    e.Handled = true;
                }
            }
        }

        /// //////////////////////////////////////////////

        private void cmsiEditUser_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListUsers.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                frmAddNewUser frm = new frmAddNewUser(ID);
                frm.ShowDialog();
                _RefreshListUsers();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsiShowUserDetails_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListUsers.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                UserDetails frm = new UserDetails(ID);
                frm.ShowDialog();
                _RefreshListUsers();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsiAddNewUser_Click(object sender, EventArgs e)
        {
            int UserID = -1;
            frmAddNewUser frm = new frmAddNewUser(UserID);
            frm.ShowDialog();
            _RefreshListUsers();
        }
        private void cmsiDeleteUser_Click(object sender, EventArgs e)
        {
            int ID = -1;
            DataGridViewRow SelectedUser = dgvListUsers.SelectedRows[0];
            if (int.TryParse(SelectedUser.Cells[0].Value.ToString(), out ID))
            {
                if (MessageBox.Show("Are You Sure Do You Want To Delte This User ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsUser.Delete(ID))
                    {
                        MessageBox.Show("User Deleted Sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshListUsers();
                    }
                    else
                    {
                        MessageBox.Show("User Deleted Fail", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmsiSendEmailToUser_Click(object sender, EventArgs e)
        {

        }

        private void cmsiPhoneCallUser_Click(object sender, EventArgs e)
        {

        }

        private void tbDVLDMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbDVLDMenu.SelectedTab == tbApplications)
            {
                tbManageApplications.SelectedTab = tbManageApplication;
                _RefreshListLocalDrivingLisenceApplications();
                return;
            }
            if (tbDVLDMenu.SelectedTab == tbpPeople)
            {
                _RefreshListPeople();
                return;
            }
            if (tbDVLDMenu.SelectedTab == tbpUsers)
            {
                _RefreshListUsers();
                return;
            }
            if (tbDVLDMenu.SelectedTab == tbAccountSettings)
            {
                ctrlUserInfo.LoadUserInfo(clsDVLDBusinessSettings.CurrentUser.ID);
                return;
            }
            if (tbDVLDMenu.SelectedTab == tbpDrivers)
            {
                _RefreshListDrivers();
                return;
            }
        }

        private void txtUsersFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUsersBy.SelectedItem.ToString() == "User ID" || cbFilterUsersBy.SelectedItem.ToString() == "_Person ID")
            {
                char UserInput = e.KeyChar;
                if (!int.TryParse(UserInput.ToString(), out _) && UserInput != 46 && UserInput != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActive.Text)
            {
                case ("All"):
                    {
                        _RefreshListUsers();
                        break;
                    }
                case ("Yes"):
                    {
                        _RefreshListUsers(true);

                        break;
                    }

                case ("No"):
                    {
                        _RefreshListUsers(false);
                        break;
                    }

            }
        }

        private void cmsiChangePassword_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListUsers.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                frmChangePassword frm = new frmChangePassword(ID);
                frm.ShowDialog();
                _RefreshListUsers();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void msiChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsDVLDBusinessSettings.CurrentUser.ID);
            frm.ShowDialog();

        }

        private void msiCurrentUserInfo_Click(object sender, EventArgs e)
        {
            UserDetails frm = new UserDetails(clsDVLDBusinessSettings.CurrentUser.ID);
            frm.ShowDialog();
        }
        void Logout()
        {
            if (MessageBox.Show("Are You Sure Do You Want To Lgout This Acount ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                clsDVLDBusinessSettings.CurrentUser = null;
                this.Hide();
                frmLogin frmLoginScreen = new frmLogin();
                frmLoginScreen.ShowDialog();
            }
        }



        private void tbpHome_Click(object sender, EventArgs e)
        {

        }

        private void msiSignOut_Click(object sender, EventArgs e)
        {
            Logout();
        }
        void _RefreshListApplicationTypes()
        {
            dgvListApplicationTypes.DataSource = clsApplicationType.GetApplicationTypesList();
        }

        private void cmsiEditApplicationType_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListApplicationTypes.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                frmUpdateApplicationType frm = new frmUpdateApplicationType((clsApplicationType.enApplicationType)ID);
                frm.ShowDialog();
                _RefreshListApplicationTypes();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void _RefreshListTestTypes()
        {
            dgvListTestTypes.DataSource = clsTestType.GetTestTypesList();
        }
        private void cmsiEditTestType_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvListTestTypes.SelectedRows[0].Cells[0].Value.ToString(), out ID))
            {
                frmUpdateTestType frm = new frmUpdateTestType((clsTestType.enTestType) ID);
                frm.ShowDialog();
                _RefreshListTestTypes();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void msiLocalLicense_Click(object sender, EventArgs e)
        {
            int ID = -1;
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(ID);
            frm.ShowDialog();
            _RefreshListLocalDrivingLisenceApplications();
        }
        void _RefreshListLocalDrivingLisenceApplications()
        {
            dgvLocalDrivingLisenceApplications.DataSource = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationsList();
        }
        void _RefreshListInternationalLicenseApplications()
        {
            dgvInternationalLisenceApplications.DataSource = clsInternationalLicense.GetInternationalLicensesList();
        }
        void _RefreshListInternationalLicenseApplicationsByStatus(bool IsActive)
        {
            dgvInternationalLisenceApplications.DataSource = clsInternationalLicense.GetInternationalLicensesListByStatus(IsActive);
        }
        void _RefreshListInternationalLicenseApplicationsByID(int InternationalLicenseID)
        {
            dgvInternationalLisenceApplications.DataSource = clsInternationalLicense.GetInternationalLicensesListByID(InternationalLicenseID);
        }
        void _RefreshListInternationalLicenseApplicationsByDriverID(int DriverID)
        {
            dgvInternationalLisenceApplications.DataSource = clsInternationalLicense.GetInternationalLicensesListByDriverID(DriverID);
        }

        private void tbManageApplicationsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbManageApplicationsMenu.SelectedTab == tbLocalDrivingLisenceApplications)
            {
                _RefreshListLocalDrivingLisenceApplications();
                return;
            }
            if (tbManageApplicationsMenu.SelectedTab == tbInternationalLisenceApplications)
            {
                _RefreshListInternationalLicenseApplications();
                return;
            }
        }
        private void _RefreshListDetainedLicenses()
        {
            dvgDetainedLicenses.DataSource = clsDetainedLicense.GetListDetainedLicenses();
        }
        private void _RefreshListDetainedLicenses(bool IsReleased)
        {
            dvgDetainedLicenses.DataSource = clsDetainedLicense.GetListDetainedLicenses(IsReleased);
        }
        private void _RefreshListDetainedLicenses(string ColumnName , string Value)
        {
            dvgDetainedLicenses.DataSource = clsDetainedLicense.GetListDetainedLicenses(ColumnName, Value);
        }
        private void _RefreshListDetainedLicensesByDetainID(int DetainID)
        {
            dvgDetainedLicenses.DataSource = clsDetainedLicense.GetListDetainedLicensesByDetainID(DetainID);
        }
        private void _RefreshListDetainedLicensesByReleaseApplicationID(int ReleaseApplicationID)
        {
            dvgDetainedLicenses.DataSource = clsDetainedLicense.GetListDetainedLicensesByReleaseApplicationID(ReleaseApplicationID);
        }
        private void cmsiShowDetails_Click1(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                frmLocalDrivingLisenceApplicationInfo frm = new frmLocalDrivingLisenceApplicationInfo(ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsiShowDetails_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                frmLocalDrivingLisenceApplicationInfo frm = new frmLocalDrivingLisenceApplicationInfo(ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsManageLocalDrivingLicenseApplication_Opening(object sender, CancelEventArgs e)
        {
            cmsiShowApplicationDetails.Enabled = true;
            cmsiEditApplication.Enabled = true;
            cmsiDeleteApplication.Enabled = true;
            cmsiCancelApplication.Enabled = true;
            cmsiShedulTests.Enabled = true;
            cmsiIssueDrivingLicenseFirstTime.Enabled = false;
            cmsiSheduleVisionTest.Enabled = false;
            cmsiSheduleWritingTest.Enabled = false;
            cmsiSheduleStreetTest.Enabled = false;
            cmsiIssueDrivingLicenseFirstTime.Enabled = false;
            cmsiShowLicense.Enabled = false;
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {

                int PassedTestCount = clsLocalDrivingLicenseApplication.PassedTest(ID);
                clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(ID);
                clsApplication Application = clsApplication.Find(LocalDrivingLicenseApplication.ApplicationID);
                if(Application.ApplicationStatus == enStatus.Cancelled || Application.ApplicationStatus == enStatus.Completed)
                {
                    cmsiEditApplication.Enabled = false;
                    cmsiDeleteApplication.Enabled = false;
                    cmsiCancelApplication.Enabled = false;
                    cmsiShedulTests.Enabled = false;
                }
                if (clsLicense.IsExist(ID))
                {
                    cmsiShowLicense.Enabled = true;
                    cmsiIssueDrivingLicenseFirstTime.Enabled = false;
                    return;
                }
                clsTestType.enTestType NextTest = clsTest.GetNextTest(PassedTestCount);
                switch (NextTest)
                {
                    case (clsTestType.enTestType.enVisionTest):
                        {
                            cmsiSheduleVisionTest.Enabled = true;
                            break;
                        }
                    case (clsTestType.enTestType.enWritingTest):
                        {
                            cmsiSheduleWritingTest.Enabled = true;
                            break;
                        }
                    case (clsTestType.enTestType.enStreetTest):
                        {
                            cmsiSheduleStreetTest.Enabled = true;
                            break;
                        }
                    case (clsTestType.enTestType.enNone):
                        {
                            cmsiIssueDrivingLicenseFirstTime.Enabled = true;
                            break;
                        }
                }
                //if (PassedTestCount == 3)
                //{
                //    // Has Lisence
                //    if (!true)
                //    {
                //        cmsiIssueDrivingLisence.Enabled = true;
                //    }
                //    else
                //    {
                //        cmsiIssueDrivingLisence.Enabled = false;
                //        cmsiShowDrivingLisence.Enabled = true;
                //    }
                //}

            }
        }


        private void cmsiSheduleVisionTest_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                frmTestAppointments frm = new frmTestAppointments(clsTestType.enTestType.enVisionTest, ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();

            }
        }

        private void cmsiSheduleWritingTest_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                frmTestAppointments frm = new frmTestAppointments(clsTestType.enTestType.enWritingTest, ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();

            }
        }

        private void cmsiSheduleStreetTest_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                frmTestAppointments frm = new frmTestAppointments(clsTestType.enTestType.enStreetTest, ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();

            }
        }

        private void cmsiIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                frmIssueDriverLicenseForTheFirstTime frm = new frmIssueDriverLicenseForTheFirstTime(ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();
            }
        }
        void _RefreshListDrivers()
        {
            dgvListDrivers.DataSource = clsDriver.GetDriversList();
        }

        private void cmsiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["NationalNo"].Value.ToString();
            clsPerson Person = clsPerson.Find(NationalNo);
            if(Person != null)
            {
                frmLicenseHistory frm = new frmLicenseHistory(Person.ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();
            }
        }

        private void cmsiCancelApplication_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                clsApplication.CancelByLocalDrivingLicenseApplicationID(ID);
                _RefreshListLocalDrivingLisenceApplications();
            }
        }

        private void cmsiDeleteApplication_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                if (clsLocalDrivingLicenseApplication.Delete(ID))
                {
                    MessageBox.Show("Application Deleted Sucessfully ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Application Deleted Fail ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _RefreshListLocalDrivingLisenceApplications();
            }
        }

        private void cmsiEditApplication_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                //frmLocalDrivingLisenceApplicationInfo frm = new frmLocalDrivingLisenceApplicationInfo(ID);
                frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(ID);
                frm.ShowDialog();
                _RefreshListLocalDrivingLisenceApplications();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsiShowLicense_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvLocalDrivingLisenceApplications.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out ID))
            {
                clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(ID);
                if(LocalDrivingLicenseApplication != null)
                {
                    frmLicenseInfo frm = new frmLicenseInfo(LocalDrivingLicenseApplication.ApplicationID);
                    frm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            int ID = -1;
            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(ID);
            frm.ShowDialog();
            _RefreshListLocalDrivingLisenceApplications();
        }
        void _RefreshListLocalDrivingLisenceApplications(clsApplication.enStatus Status)
        {
            dgvLocalDrivingLisenceApplications.DataSource = clsLocalDrivingLicenseApplication.GetFilteredLocalDrivingLisenceApplicationsList(Status);
        }
        void _RefreshListLocalDrivingLisenceApplications(string ColumnName, string Value)
        {
            dgvLocalDrivingLisenceApplications.DataSource = clsLocalDrivingLicenseApplication.GetFilteredLocalDrivingLisenceApplicationsList(ColumnName, Value);
        }
        void _RefreshListLocalDrivingLisenceApplications(int LocalDrivingLisenceApplicationID)
        {
            dgvLocalDrivingLisenceApplications.DataSource = clsLocalDrivingLicenseApplication.GetFilteredLocalDrivingLisenceApplicationsList(LocalDrivingLisenceApplicationID);
        }

        private void FilterLocalDrivingLisenceApplication_Changed(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterLocalDrivingLicenseApplicationsBy.SelectedItem.ToString().Replace(" ", "");
            switch (FilterColumn)
            {
                case ("None"):
                    {
                        txtLocalDrivingLicenseApplicationsFilter.Visible = false;
                        cbLocalDrivingLicenseApplicationsStatus.Visible = false;
                        _RefreshListLocalDrivingLisenceApplications();
                        break;
                    }
                case ("Status"):
                    {
                        txtLocalDrivingLicenseApplicationsFilter.Visible = false;
                        cbLocalDrivingLicenseApplicationsStatus.Visible = true;

                        break;
                    }

                case ("LocalDrivingLicenseApplicationID"):
                    {
                        txtLocalDrivingLicenseApplicationsFilter.PlaceholderText = "Please Enter " + cbFilterLocalDrivingLicenseApplicationsBy.Text;
                        txtLocalDrivingLicenseApplicationsFilter.Visible = true;
                        cbLocalDrivingLicenseApplicationsStatus.Visible = false;
                        int ID;
                        if (int.TryParse(txtLocalDrivingLicenseApplicationsFilter.Text, out ID))
                        {
                            _RefreshListLocalDrivingLisenceApplications(ID);
                            return;
                        }

                        break;
                    }
                default:
                    {
                        txtLocalDrivingLicenseApplicationsFilter.PlaceholderText = "Please Enter " + cbFilterLocalDrivingLicenseApplicationsBy.Text;
                        txtLocalDrivingLicenseApplicationsFilter.Visible = true;
                        cbLocalDrivingLicenseApplicationsStatus.Visible = false;
                        _RefreshListLocalDrivingLisenceApplications(FilterColumn, txtLocalDrivingLicenseApplicationsFilter.Text);
                        break;
                    }

            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalDrivingLicenseApplicationsStatus.Text == "All")
            {
                _RefreshListLocalDrivingLisenceApplications();
                return;
            }
            else
            {
                _RefreshListLocalDrivingLisenceApplications("Status" , cbLocalDrivingLicenseApplicationsStatus.Text);
            }
        }

        private void txtLocalDrivingLicenseApplicationsFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterLocalDrivingLicenseApplicationsBy.SelectedItem.ToString() == "Local DrivingLicense Application ID")
            {
                char UserInput = e.KeyChar;
                if (!int.TryParse(UserInput.ToString(), out _) && UserInput != 46 && UserInput != 8)
                {
                    e.Handled = true;
                }
            }
        }
        void _RefreshListDrivers(string ColumnName, string Value)
        {
            dgvListDrivers.DataSource = clsDriver.GetFilteredDriversList(ColumnName, Value);
        }
        void _RefreshListDriversByPersonID(int PersonID)
        {
            dgvListDrivers.DataSource = clsDriver.GetFilteredDriversListByPersonID(PersonID);
        }

        void _RefreshListDriversByDriverID(int DriverID)
        {
            dgvListDrivers.DataSource = clsDriver.GetFilteredDriversListByDriverID(DriverID);
        }
        private void FilterDriver_Changed(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterDriversBy.SelectedItem.ToString().Replace(" ", "");
            if (FilterColumn == "None")
            {
                txtDriversFilter.Visible = false;
                _RefreshListDrivers();
                return;
            }
            txtDriversFilter.Visible = true;
            txtDriversFilter.PlaceholderText = "Please Enter " + cbFilterDriversBy.SelectedItem.ToString();
            if (FilterColumn == "DriverID")
            {
                int ID;
                if (int.TryParse(txtDriversFilter.Text, out ID))
                {
                    _RefreshListDriversByDriverID(ID);
                }

                return;
            }
            if (FilterColumn == "PersonID")
            {
                int ID;
                if (int.TryParse(txtDriversFilter.Text, out ID))
                {
                    _RefreshListDriversByPersonID(ID);
                }

                return;
            }
            _RefreshListDrivers(FilterColumn, txtDriversFilter.Text);
            return;
        }
        private void txtDriversFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterDriversBy.SelectedItem.ToString() == "Driver ID" || cbFilterDriversBy.SelectedItem.ToString() == "_Person ID")
            {
                char DriverInput = e.KeyChar;
                if (!int.TryParse(DriverInput.ToString(), out _) && DriverInput != 46 && DriverInput != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void msiInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenseApplication frm = new frmAddNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void btnAddInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenseApplication frm = new frmAddNewInternationalLicenseApplication();
            frm.ShowDialog();
            _RefreshListInternationalLicenseApplications();
        }

        private void InternationalLicenseApplicationsFiltre_Changed(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterInternationalLicenseApplicationsBy.SelectedItem.ToString().Replace(" ", "");
            switch (FilterColumn)
            {
                case ("None"):
                    {
                        txtInternationalLicenseApplicationsFilter.Visible = false;
                        cbIsActiveInternationalLicenseApplications.Visible = false;
                        _RefreshListInternationalLicenseApplications();
                        break;
                    }
                case ("IsActive"):
                    {
                        txtInternationalLicenseApplicationsFilter.Visible = false;
                        cbIsActiveInternationalLicenseApplications.Visible = true;
                        _RefreshListInternationalLicenseApplications();
                        break;
                    }

                case ("InternationalLicenseApplicationID"):
                    {
                        txtInternationalLicenseApplicationsFilter.PlaceholderText = "Please Enter " + cbFilterInternationalLicenseApplicationsBy.Text;
                        txtInternationalLicenseApplicationsFilter.Visible = true;
                        cbIsActiveInternationalLicenseApplications.Visible = false;
                        int ID;
                        if (int.TryParse(txtInternationalLicenseApplicationsFilter.Text, out ID))
                        {
                            _RefreshListInternationalLicenseApplicationsByID(ID);
                            return;
                        }

                        break;
                    }
                case ("DriverID"):
                    {
                        txtInternationalLicenseApplicationsFilter.PlaceholderText = "Please Enter " + cbFilterInternationalLicenseApplicationsBy.Text;
                        txtInternationalLicenseApplicationsFilter.Visible = true;
                        cbIsActiveInternationalLicenseApplications.Visible = false;
                        int ID;
                        if (int.TryParse(txtInternationalLicenseApplicationsFilter.Text, out ID))
                        {
                            _RefreshListInternationalLicenseApplicationsByDriverID(ID);
                            return;
                        }

                        break;
                    }

            }
        }

        private void cbInternationalLicenseApplicationsStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActiveInternationalLicenseApplications.Text)
            {
                case ("All"):
                    {
                        _RefreshListInternationalLicenseApplications();
                        break;
                    }
                case ("Yes"):
                    {
                        _RefreshListInternationalLicenseApplicationsByStatus(true);
                        break;
                    }

                case ("No"):
                    {
                        _RefreshListInternationalLicenseApplicationsByStatus(false);
                        break;
                    }

            }
        }

        private void txtInternationalLicenseApplicationsFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void showPersonLicenseHystoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ID = -1;
            if (int.TryParse(dgvInternationalLisenceApplications.SelectedRows[0].Cells["DriverID"].Value.ToString(), out ID))
            {
                clsDriver Driver = clsDriver.Find(ID);
                if (Driver != null)
                {
                    frmLicenseHistory frm = new frmLicenseHistory(Driver.PersonID);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid ID , Please Select A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Select A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvInternationalLisenceApplications.SelectedRows[0].Cells["InternationalLicenseID"].Value.ToString(), out ID))
            {
                frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(ID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Enter A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(dgvInternationalLisenceApplications.SelectedRows[0].Cells["DriverID"].Value.ToString(), out ID))
            {
                clsDriver Driver = clsDriver.Find(ID);
                if (Driver != null)
                {
                    PersonDetails frm = new PersonDetails(Driver.PersonID);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid ID , Please Select A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("Invalid ID , Please Select A Valid One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmiRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void cmiRemplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            frmReplacementForDamagedOrLostLicense frm = new frmReplacementForDamagedOrLostLicense();
            frm.ShowDialog();
        }

        private void cmiRetakeTest_Click(object sender, EventArgs e)
        {
            tbDVLDMenu.SelectedTab = tbApplications;
            tbManageApplications.SelectedTab = tbManageApplication;
            tbManageApplicationsMenu.SelectedTab = tbLocalDrivingLisenceApplications;
        }

        private void msiDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void msiReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void DetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }
        /*   ----------------------------------------------------------------------------- */
        private void FilterDetainLicenses_Changed(object sender, EventArgs e)
        {
  
            string FilterColumn = cbFilterDetainedLicensesBy.SelectedItem.ToString().Replace(" ", "");
            switch (FilterColumn)
            {
                case ("None"):
                    {
                        txtDetainedLicensesFilter.Visible = false;
                        cbIsReleased.Visible = false;
                        _RefreshListDetainedLicenses();
                        break;
                    }
                case ("IsReleased"):
                    {
                        txtDetainedLicensesFilter.Visible = false;
                        cbIsReleased.Visible = true;
                        _RefreshListDetainedLicenses();
                        break;
                    }

                case ("ReleaseApplicationID"):
                    {
                        txtDetainedLicensesFilter.PlaceholderText = "Please Enter _Person ID";
                        txtDetainedLicensesFilter.Visible = true;
                        cbIsReleased.Visible = false;
                        int ID;
                        if (int.TryParse(txtDetainedLicensesFilter.Text, out ID))
                        {
                            _RefreshListDetainedLicensesByReleaseApplicationID(ID);
                            return;
                        }

                        break;
                    }
                case ("DetainID"):
                    {
                        txtDetainedLicensesFilter.PlaceholderText = "Please Enter Detain ID";
                        txtDetainedLicensesFilter.Visible = true;
                        cbIsReleased.Visible = false;
                        int ID;
                        if (int.TryParse(txtDetainedLicensesFilter.Text, out ID))
                        {
                            _RefreshListDetainedLicensesByDetainID(ID);
                        }

                        break;
                    }
                case ("FullName"):
                    {
                        txtDetainedLicensesFilter.PlaceholderText = "Please Enter Full Name";
                        txtDetainedLicensesFilter.Visible = true;
                        cbIsReleased.Visible = false;
                        _RefreshListDetainedLicenses("FullName", txtDetainedLicensesFilter.Text);

                        break;
                    }
                case ("NationalNo"):
                    {
                        txtDetainedLicensesFilter.PlaceholderText = "Please Enter National No";
                        txtDetainedLicensesFilter.Visible = true;
                        cbIsReleased.Visible = false;
                        _RefreshListDetainedLicenses("NationalNo", txtDetainedLicensesFilter.Text);
                        break;
                    }
            }

        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsReleased.Text)
            {
                case ("All"):
                    {
                        _RefreshListDetainedLicenses();
                        break;
                    }
                case ("Yes"):
                    {
                        _RefreshListDetainedLicenses(true);

                        break;
                    }

                case ("No"):
                    {
                        _RefreshListDetainedLicenses(false);
                        break;
                    }

            }
        }

        private void txtDetainedLicensesFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterDetainedLicensesBy.SelectedItem.ToString() == "Detain ID" || cbFilterDetainedLicensesBy.SelectedItem.ToString() == "Release Application ID")
            {
                char UserInput = e.KeyChar;
                if (!int.TryParse(UserInput.ToString(), out _) && UserInput != 46 && UserInput != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void tbManageApplications_MouseUp(object sender, MouseEventArgs e)
        {
            //if (tbManageApplications.GetTabRect(0).Contains(e.Location))
            //{
            //    tbManageApplications.SelectedIndex = LastTabIndex;
            //    var MousePosition = Cursor.Position;
            //    cmsDrivingLicensesServices.Show(MousePosition);
            //}
        }

        private void tbManageApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbManageApplications.SelectedTab == tbDrivingLicensesServices)
            {

                tbManageApplications.SelectedIndex = LastTabIndex;
                var MousePosition = Cursor.Position;
                cmsDrivingLicensesServices.Show(MousePosition);
                return;
            }
            LastTabIndex = tbManageApplications.SelectedIndex;
            if (tbManageApplications.SelectedTab == tbManageApplicationTypes)
            {
                _RefreshListApplicationTypes();
                return;
            }
            if (tbManageApplications.SelectedTab == tbManageTestTypes)
            {
                _RefreshListTestTypes();
                return;
            }
            if (tbManageApplications.SelectedTab == tbManageApplication)
            {
                _RefreshListLocalDrivingLisenceApplications();
                return;
            }
            if (tbManageApplications.SelectedTab == tbDetainLicenses)
            {
                _RefreshListDetainedLicenses();
                return;
            }
        }
    }
}
