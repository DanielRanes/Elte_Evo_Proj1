using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bead.Logics;
using Bead.Models;

namespace Bead.Forms
{
    public partial class OwnMeresekForm : Form
    {
        User CurrentUser;
        UserLogic uLogic;

        public OwnMeresekForm(User user)
        {
            CurrentUser = user;
            uLogic = new UserLogic();
            InitializeComponent();

            dg_OwnMeresek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_OwnMeresek.MultiSelect = false;
            dg_OwnMeresek.ReadOnly = true;
            dg_OwnMeresek.AutoGenerateColumns = false;

            LoadOwnMeresek();
            SetUpColumns();
        }

        private void LoadOwnMeresek()
        {
            dg_OwnMeresek.DataSource = uLogic.FillOwnMeresekList(CurrentUser);
        }

        private void SetUpColumns()
        {
            // a manuális oszlopok miatt kell megadni a propertyname-eket
            dg_OwnMeresek.Columns["MeresId"].DataPropertyName = "MeresId";
            dg_OwnMeresek.Columns["MeresType"].DataPropertyName = "MeresType";
            dg_OwnMeresek.Columns["MeresDate"].DataPropertyName = "MeresDate";
            dg_OwnMeresek.Columns["MeresHomerseklet"].DataPropertyName = "MeresHomerseklet";
            dg_OwnMeresek.Columns["MeresHarmatpont"].DataPropertyName = "MeresHarmatpont";
            dg_OwnMeresek.Columns["MeresLegnyomas"].DataPropertyName = "MeresLegnyomas";
            dg_OwnMeresek.Columns["MeresCsapadek"].DataPropertyName = "MeresCsapadek";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SzerkM_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg_OwnMeresek.SelectedRows[0];

            int meresId = (int)row.Cells["MeresId"].Value;
            
            Meresek meres = uLogic.FindCurrentMeres(meresId);

            EditMeres f = new EditMeres(meres);
            f.ShowDialog();
            LoadOwnMeresek();
        }
        
    }
}