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
    public partial class ctrlApplicationInfo : UserControl
    {

        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }
        private clsApplication Application = new clsApplication();
        private void FillApplicationInfo(clsApplication Application)
        {
            clsApplicationType ApplicationType = clsApplicationType.Find(Application.ApplicationTypeID);
            txtID.Text = Application.ApplicationID.ToString();
            txtStatus.Text = Application.ApplicationStatus.ToString();
            txtType.Text = ApplicationType.Title;
            txtApplicant.Text = clsPerson.Find(Application.ApplicationPersonID).FullName();
            txtFees.Text = Application.PaidFees.ToString();
            dtpDate.Value = Application.ApplicationDate;
            dtpStatusDate.Value = Application.LastStatusDate;
            txtCreatedBy.Text = clsUser.Find( Application.CreatedByUserID).UserName;
        }
        public void LoadApplicationInfo(int ApplicationID)
        {
            if (ApplicationID != -1)
            {
                clsApplication Application = clsApplication.Find(ApplicationID);
                if (Application != null)
                {
                    this.Application = Application;
                    FillApplicationInfo(this.Application);
                }
                else
                {
                    MessageBox.Show($"Local Driving Lisence With ID = {ApplicationID} Not Found", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void btnViewPersonInfo_Click(object sender, EventArgs e)
        {
                PersonDetails frm = new PersonDetails(Application.ApplicationPersonID);
                frm.ShowDialog();
        }

        private void btnViewUserInfo_Click(object sender, EventArgs e)
        {
            UserDetails frm = new UserDetails(Application.CreatedByUserID);
            frm.ShowDialog();
        }
    }
}

