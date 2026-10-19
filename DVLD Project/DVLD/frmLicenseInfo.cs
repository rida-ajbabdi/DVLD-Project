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
    public partial class frmLicenseInfo : Form
    {
        int ApplicationID = -1;
        public frmLicenseInfo(int ApplicationID)
        {
            InitializeComponent();
            this.ApplicationID = ApplicationID;
        }



        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo.LoadDriverLicenseInfoByApplicationID(ApplicationID);
        }
    }
}
