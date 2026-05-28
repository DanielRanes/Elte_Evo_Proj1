using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Bead.Logics;

namespace Bead.Forms
{
    public partial class LoginForm : Form
    {
        AuthService formlogic;
        User curUser;
        public LoginForm()
        {
            InitializeComponent();
            lbl_error.Visible = false;
            formlogic = new(curUser);
            curUser = null;
        }
        #region FormOwnL
        private void IdentifyUser()
        {
            if (formlogic.CheckLogin(tb_UserName.Text, tb_PassW.Text))
            {
                curUser = formlogic.LogicCurrentUser;
                FilterLogin();
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = formlogic.ErrorMessage;
            }
        }

        private void FilterLogin()
        {
            if (curUser.UserType == "User" || curUser.UserType == "Manager")
            {
                UserSite uSite = new UserSite(curUser);
                uSite.ShowDialog();
            }
            else
            {
                AdminSite rSite = new AdminSite(curUser);
                rSite.ShowDialog();
            }


            //setback
            curUser = null;
            lbl_error.Text = "";
            tb_UserName.Clear();
            tb_PassW.Clear();
            
        }
        #endregion

        #region buttons
        private void btn_GoToRegist_Click(object sender, EventArgs e)
        {
            RegistForm f2 = new RegistForm();
            f2.ShowDialog();
            tb_UserName.Clear();
            tb_PassW.Clear();
        }
        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            IdentifyUser();
        }

        private void cb_PS_CheckedChanged(object sender, EventArgs e)
        {
            tb_PassW.UseSystemPasswordChar = !cb_PS.Checked;
        }
        #endregion
    }
}
