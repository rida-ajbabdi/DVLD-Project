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
    public partial class ctrlFiltredLicense : UserControl
    {
        public event Action<int> OnLicenseSelector = delegate { };
        protected virtual void LicenseSelector(int ID)
        {
            Action<int> Hundler = OnLicenseSelector;
            if(Hundler != null)
            {
                Hundler(ID);
            }
        }
        public ctrlFiltredLicense()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if(int.TryParse(txtLicenseID.Text, out ID))
            {
                ctrlDriverLicenseInfo.LoadDriverLicenseInfo(ID);
                LicenseSelector(ID);
            }
            
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DriverInput = e.KeyChar;
            if (!int.TryParse(DriverInput.ToString(), out _) && DriverInput != 46 && DriverInput != 8)
            {
                e.Handled = true;
            }
        }
    }
}
