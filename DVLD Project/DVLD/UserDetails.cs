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
using TheArtOfDevHtmlRenderer.Adapters;

namespace DVLD
{
    public partial class UserDetails : Form
    {
        int _UserID;
        public UserDetails(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void UserDetails_Load(object sender, EventArgs e)
        {
            ctrlUserInfo.LoadUserInfo(_UserID);
        }

    }
}
