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
    public partial class frmLicenseHistory : Form
    {
        private int PersonID = -1;
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
                ctrlPersonInfo.LoadPersonInfo(PersonID);
                ctrlDriverLicenses.LoadDriverLicensesByPersonID(PersonID);
        }


    }
}
