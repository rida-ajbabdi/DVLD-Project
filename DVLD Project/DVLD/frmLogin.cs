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
using Microsoft.Win32;
using System.Diagnostics;
using DVLDBusinessLayer.Properties;
namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        enum enLogin
        {
            Sucessfully, Wrong, ThreeWrongLogin
        }
        void SaveUserNamePassowordToRegistry(string UserName , string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string UserNamePath = @"UserName";
            string PasswordPath = @"Password";
            try
            {
                Registry.SetValue(KeyPath, UserNamePath, UserName, RegistryValueKind.String);
                Registry.SetValue(KeyPath, PasswordPath, Password, RegistryValueKind.String);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DeleteUserNamePassowordFromRegistry()
        {
            SaveUserNamePassowordToRegistry("" , "");
        }
        bool IsLogin()
        {
            clsUser CurrentUser = null;
            if ((CurrentUser = clsUser.Find(txtUserName.Text, txtPassword.Text)) != null)
            {
                if (CurrentUser.IsActive)
                {
                    clsDVLDBusinessSettings.CurrentUser = CurrentUser;
                    if (chkRemenber.Checked)
                    {

                        //DVLDBusinessLayer.Properties.Settings.Default.LastUserName = txtUserName.Text;
                        //DVLDBusinessLayer.Properties.Settings.Default.LastPassword = txtPassword.Text;
                        //DVLDBusinessLayer.Properties.Settings.Default.Save();
                        SaveUserNamePassowordToRegistry(txtUserName.Text , txtPassword.Text);
                    }
                    else
                    {
                        //DVLDBusinessLayer.Properties.Settings.Default.LastUserName = null;
                        //DVLDBusinessLayer.Properties.Settings.Default.LastPassword = null;
                        //DVLDBusinessLayer.Properties.Settings.Default.Save();
                        DeleteUserNamePassowordFromRegistry();
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Deactivated Account , Please Contact Your Admin", "Deactivated Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid User Name / Passoword", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
        }
        enLogin LoginResult()
        {
            if (IsLogin())
            {
                return enLogin.Sucessfully;
            }
            else if (Settings.Default.LoginCounter == 3)
            {
                return enLogin.ThreeWrongLogin;
            }
            else
            {
                Settings.Default.LoginCounter++;
                Settings.Default.Save();
                return enLogin.Wrong;
            }
        }

        void StartProject()
        {
            Settings.Default.TimerCounter = 30;
            Settings.Default.LoginCounter = 1;
            Settings.Default.Save();
            this.Hide();

            using (Form1 HomeProject = new Form1())
            {
                HomeProject.ShowDialog();
            }
            this.Close();
        }
        void InitializeLogin()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            chkRemenber.Checked = false;
        }
        void WrongLogin()
        {
            InitializeLogin();
            errorProvider1.SetError(txtUserName, "Invalid UserName !");
            errorProvider1.SetError(txtPassword, "Invalid Passoword !");
        }

        void Login(enLogin LoginResult)
        {
            switch (LoginResult)
            {
                case enLogin.Sucessfully:
                    //clsLoginRegister LoginRegister = new clsLoginRegister();
                    //LoginRegister.Add(clsGlobal.LoginRegistersFileName);

                    StartProject();
                    break;
                case enLogin.Wrong:
                    WrongLogin();
                    break;
                case enLogin.ThreeWrongLogin:
                    {
                        pnlLogin.Enabled = false;
                        timer1.Start();
                        clsLogger.LogExeption("Temporary login input restriction applied after 3 invalid attempts. UI disabled for 30 seconds." , EventLogEntryType.Warning);
                        break;
                    }
            }
        }
        bool GetUserNamePasswordFromRegistry(ref string UserName , ref string Password)
        {
            const string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            const string UserNamePath = @"UserName";
            const string PasswordPath = @"Password";
            try
            {
                UserName = (string)Registry.GetValue(KeyPath, UserNamePath, null);
                Password = (string)Registry.GetValue(KeyPath, PasswordPath , null);
                return (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(UserName));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            //if (DVLDBusinessLayer.Properties.Settings.Default.LastUserName != null &&
            //    DVLDBusinessLayer.Properties.Settings.Default.LastPassword != null)
            //{
            //    txtUserName.Text = DVLDBusinessLayer.Properties.Settings.Default.LastUserName;
            //    txtPassword.Text = DVLDBusinessLayer.Properties.Settings.Default.LastPassword;
            //    chkRemenber.Checked = true;
            //}
            //else
            //    chkRemenber.Checked = false;
            
            string UserName = null;
            string Password = null;
            if(GetUserNamePasswordFromRegistry(ref UserName, ref Password))
            {
                txtUserName.Text = UserName ?? "";
                txtPassword.Text = Password ?? "";
            }
            if (Settings.Default.TimerCounter > 0 && Settings.Default.LoginCounter==3)
                Login(enLogin.ThreeWrongLogin);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Settings.Default.TimerCounter > 0)
            {
                pnlLogin.Enabled = false;
                pnlTimer.Visible = true;
                Settings.Default.TimerCounter--;
                Settings.Default.Save();
                label2.Text = Settings.Default.TimerCounter.ToString() + " s ...";
            }
            else
            {
                Settings.Default.TimerCounter = 30;
                Settings.Default.LoginCounter = 1;
                Settings.Default.Save();
                pnlTimer.Visible = false;
                pnlLogin.Enabled = true;
                InitializeLogin();
                errorProvider1.SetError(txtUserName, "");
                errorProvider1.SetError(txtPassword, "");
                timer1.Stop();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(LoginResult());
        }
    }
}
