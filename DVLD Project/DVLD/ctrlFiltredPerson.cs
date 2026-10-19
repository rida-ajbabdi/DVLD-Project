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
    public partial class ctrlFiltredPerson : UserControl
    {
        public clsPerson Person = new clsPerson();

        
        public event Action<clsPerson> OnPerson_Selector = delegate { };
        protected virtual void Person_Selector(clsPerson obj)
        {
            Action<clsPerson> Hundler = OnPerson_Selector;
            if (Hundler != null)
            {
                Hundler(obj);
            }
        }
        public ctrlFiltredPerson()
        {
            InitializeComponent(); 
        }



        ////
        private void cbFilterPersonBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterPersonBy.Text != "None")
            {
                txtFilter.Visible = true;
                txtFilter.PlaceholderText = "Please Enter " + cbFilterPersonBy.Text;
            }
            else
                txtFilter.Visible = false;
        }

        private void btnSesrch_Click(object sender, EventArgs e)
        {
            switch (cbFilterPersonBy.Text.ToString())
            {
                case "Person ID":
                    {
                        int ID = -1;
                        if (int.TryParse(txtFilter.Text, out ID))
                        {
                            ctrlPersonInfo.LoadPersonInfo(ID);
                        }
                        break;
                    }
                case "National No":
                    {
                        ctrlPersonInfo.LoadPersonInfo(txtFilter.Text);
                        break;
                    }
            }
        }
        private void FillInformation(object sender, clsPerson Person)
        {
            this.Person = Person;
            ctrlPersonInfo.LoadPersonInfo(Person.ID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = -1;

            Add___Edit_Form frm = new Add___Edit_Form(ID);
            frm.DataBack += FillInformation;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        public void LoadPersonInfo(int ID)
        {
            ctrlPersonInfo.LoadPersonInfo(ID);
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {


            string SelectedValue = cbFilterPersonBy.SelectedItem.ToString();
            if (e.KeyChar == (char)13)
                btnSesrch.PerformClick();
            if (SelectedValue == "Person ID")
            {
                char UserInput = e.KeyChar;
                if (!int.TryParse(UserInput.ToString(), out _) && UserInput != 46 && UserInput != 8)
                {
                    e.Handled = true;
                }
            }

        }
        public void DisableFilter()
        { 
            gbFilterBy.Visible = false;
            gbFilterBy.Enabled = false;
        }
        private void ctrlFiltredPerson_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfo_OnPersonSelector(clsPerson obj)
        {
            Person = obj;
            OnPerson_Selector(obj);
        }
    }
}
