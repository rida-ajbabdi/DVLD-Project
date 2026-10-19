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
    public partial class ctrlDriverLicenses : UserControl
    {
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        public void LoadDriverLicensesByPersonID(int PersonID)
        {
            clsDriver Driver = clsDriver.FindByPersonID(PersonID);
            if(Driver == null)
            {
                MessageBox.Show("No Driver linked With This Person" , "Person Not A Driver" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            LoadDriverLicensesByDriverID(Driver.DriverID);
            //dgvListLocalDriverLicenses.DataSource = clsLicense.GetDriverLicensesListByPersonID(PersonID);
            //dgvListInternationalDriverLicenses.DataSource = clsInternationalLicense.GetInternationalLicensesListByPersonID(PersonID);
        }
        public void LoadDriverLicensesByDriverID(int Driver)
        {

            dgvListLocalDriverLicenses.DataSource = clsLicense.GetDriverLicensesListByDriverID(Driver);
            dgvListInternationalDriverLicenses.DataSource = clsInternationalLicense.GetInternationalLicensesListByDriverID(Driver);
        }


    }
}
