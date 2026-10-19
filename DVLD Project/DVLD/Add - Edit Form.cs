using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDBusinessLayer.clsPerson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DVLDBusinessLayer;
namespace DVLD
{
    public partial class Add___Edit_Form : Form
    {
        public clsPerson Person;
        public delegate void DataBackEventHandler(object sender, clsPerson Person);
        public event DataBackEventHandler DataBack;
        public Add___Edit_Form(int ID)
        {
            InitializeComponent();
            Person = this.ctrlPerson.LoadPersonInfo(ID);
        }
        private void Add___Edit_Form_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Person!= null)
            {
                this.ctrlPerson.UpdatePersonInfo(Person);
                if(Person.Save())
                {
                    this.ctrlPerson.FillPersonInfo(Person);
                    MessageBox.Show($"Save Sucessfully ", "Save Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Save Faild ! , Please Try Again ", "Save Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"_Person Not Found ! , Please Try Again ", "Save Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlPerson_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPerson_OnValidatingInformation()
        {
            if (ctrlPerson.IsValidateInformation)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Person.ID != -1)
            {
                DataBack?.Invoke(this, Person);
            }
        }
    }
}
