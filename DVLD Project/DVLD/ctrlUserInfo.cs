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
    public partial class ctrlUserInfo : UserControl
    {
        public clsUser User;
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        private void _ResetUserInfo()
        {
            txtUserID.Text = "";
            txtUserName.Text = "";
            chkIsActive.Checked = false;
        }
        public void LoadUserInfo(int UserID)
        {
            User = DVLDBusinessLayer.clsUser.Find(UserID);
            if (User != null)
            {
                ctrlPersonInfo.LoadPersonInfo(User.PersonID);
                txtUserID.Text = User.ID.ToString();
                txtUserName.Text = User.UserName;
                chkIsActive.Checked = User.IsActive;
            }
            else
            {
                _ResetUserInfo();
                MessageBox.Show($"User With UserID = {UserID} Not Found , Please Enter a Valid One ", "_Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
