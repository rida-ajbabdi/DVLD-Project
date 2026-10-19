using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD
{
    public partial class frmTakeTest : Form
    {
        private clsTest Test = new clsTest();
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            if(TestAppointmentID!=-1)
            {
                if(clsTestAppointement.IsExist(TestAppointmentID))
                {
                    clsTest Test = new clsTest();
                    if((Test = clsTest.Find(TestAppointmentID))!=null)
                    {
                        this.Test = Test;
                    }
                    else
                    {
                        this.Test.TestAppointmentID = TestAppointmentID;
                    }
                        
                }
            }
        }
        private void _LoadTestResultInfo(clsTest Test)
        {
            if (Test.TestID != -1)
            {
                rbPass.Checked = Test.TestResult;
                rbFail.Checked = !Test.TestResult;
                txtNote.Text = Test.Notes;
                txtTestID.Text = Test.TestID.ToString();
                gbTestinfo.Enabled = false;
            }
            else
            {
                rbPass.Checked = false;
                rbFail.Checked = false;
                txtNote.Text = "";
                txtTestID.Text = "*********";
                gbTestinfo.Enabled = true;
            }
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlTestInfo.LoadTestInfo(Test.TestAppointmentID);
            _LoadTestResultInfo(Test);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Test.TestResult= rbPass.Checked;
            Test.Notes = txtNote.Text;
            if(Test.TestID == -1)
            {
                if(Test.AddNew())
                {
                    _LoadTestResultInfo(Test);
                    MessageBox.Show("Save Sucessfully" , "Sucess" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Save Fail", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
