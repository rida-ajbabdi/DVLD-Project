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
    public partial class frmLocalDrivingLisenceApplicationInfo : Form
    {
        private int LocalDrivingLicenseApplicationID = -1;
        public frmLocalDrivingLisenceApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmLocalDrivingLisenceApplicationInfo_Load(object sender, EventArgs e)
        {
            this.ctrlLocalDrivingLlisenceApplicationInfo.LoadLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
    }
}
