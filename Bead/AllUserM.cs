using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Bead.Logics;
using Bead.Models;

namespace Bead.Forms
{
    public partial class AllUserM : Form
    {
        User currentuser;
        public AllUserM(User cUser)
        {
            currentuser = cUser;
            InitializeComponent();

            dg_AllUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_AllUser.MultiSelect = false;
            dg_AllUser.ReadOnly = true;
            dg_AllUser.AutoGenerateColumns = false;

            LoadAllUsers();
            SetUpColumns();
        }
        private void LoadAllUsers()
        {
            AdminLogic aLogic = new();
            dg_AllUser.DataSource = aLogic.FillAllUserList();
        }

        private void SetUpColumns()
        {
            dg_AllUser.Columns["UserID"].DataPropertyName = "UserID";
            dg_AllUser.Columns["Username"].DataPropertyName = "Username";
            dg_AllUser.Columns["UserRank"].DataPropertyName = "UserRank";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UserM_Click_1(object sender, EventArgs e)
        {
            if (dg_AllUser.SelectedRows.Count == 0) return;

            DataGridViewRow row = dg_AllUser.SelectedRows[0];
            int selectedId = (int)row.Cells["UserID"].Value;

            using (Bead_Database db = new Bead_Database())
            {
                User UserT = (
                    from u in db.Users
                    where u.Id == selectedId
                    select u
                ).FirstOrDefault();

                if (currentuser.Id == UserT.Id)
                {
                    MessageBox.Show("Magadat nem szerkesztheted!");
                }

                else if (UserT != null)
                {
                    EditUserForm EditUForm = new EditUserForm(UserT);
                    EditUForm.ShowDialog();
                }
            }

            LoadAllUsers();
        }
    }
}