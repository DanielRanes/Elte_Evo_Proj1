using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Bead.Logics;

namespace Bead.Forms
{
    public partial class RegistForm : Form
    {
        AuthService fm;
        public RegistForm()
        {
            InitializeComponent();
            lbl_error.Visible = false;
            fm = new();
        }
        #region FormOwnL

        private void RegistUser()
        {
            if (!fm.AddUser(tb_RegUsername.Text, tb_RegPassW.Text, tb_RegPassW2.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = fm.ErrorMessage;
            }
            else
            {
                MessageBox.Show("Sikeres regisztráció!", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void AddAdmin()
        {
            if (!fm.AddAdmin(tb_RegUsername.Text, tb_RegPassW.Text, tb_RegPassW2.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = fm.ErrorMessage;
            }
            else
            {
                MessageBox.Show("ADMIN Sikeres regisztráció!", "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
        #endregion

        #region buttons
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Regist_Click(object sender, EventArgs e)
        {
            RegistUser();
        }

        private void btn_AdminM_Click(object sender, EventArgs e)
        {
            AddAdmin();
        }
        #endregion

        private void cb_PS_CheckedChanged(object sender, EventArgs e)
        {
            tb_RegPassW.UseSystemPasswordChar = !cb_PS.Checked;
            tb_RegPassW2.UseSystemPasswordChar = !cb_PS.Checked;
        }
    }
}
