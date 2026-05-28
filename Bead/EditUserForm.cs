using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bead.Logics;

namespace Bead.Forms
{
    public partial class EditUserForm : Form
    {
        User targettedUser;
        AdminLogic adminL;
        string OriginalName;
        public EditUserForm(User TUser)
        {
            targettedUser = TUser;
            adminL = new AdminLogic();
            OriginalName = targettedUser.Name;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cb_UserRank.Items.Add("User");
            cb_UserRank.Items.Add("SuperAdmin");

            if (targettedUser.UserType == "User")
            {
                cb_UserRank.SelectedIndex = 0;
            }
            else
            {
                cb_UserRank.SelectedIndex = 1;
            }

            tb_UserName.Text = targettedUser.Name;
            lbl_UserId.Text = targettedUser.Id.ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            adminL.ModifyUserDB(targettedUser, tb_UserName.Text, OriginalName, cb_UserRank.SelectedIndex);
            if (adminL.ErrorMessage == "")
            {
                this.Close();
            }
            lbl_error.Text = adminL.ErrorMessage;
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törlöd?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                adminL.DeleteUserDB(targettedUser);
            }
        }
    }
}
