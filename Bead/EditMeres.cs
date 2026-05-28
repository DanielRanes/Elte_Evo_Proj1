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
    public partial class EditMeres : Form
    {
        Meresek currentM;
        UserLogic uLogic;
        string merestype;
        public EditMeres(Meresek sm)
        {
            currentM = sm;
            uLogic = new();
            InitializeComponent();
            LoadMeres();
            SetNUDs();

        }
        private void SetNUDs()
        {
            nud_Homerseklet.DecimalPlaces = 2;
            nud_Harmatpont.DecimalPlaces = 2;
            nud_Legnyomas.DecimalPlaces = 2;
            nud_Csapadek.DecimalPlaces = 2;
        }
        private void LoadMeres()
        {
            lbl_MeresId.Text = $"({currentM.Id}.) Mérés";
            nud_Homerseklet.Value = (decimal)currentM.Homerseklet;
            dtp_Meres.Format = DateTimePickerFormat.Custom;
            dtp_Meres.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_Meres.ShowUpDown = true;
            dtp_Meres.Value = currentM.Date;
            FillComb();
            TypeSwitcher();
        }

        private void TypeSwitcher()
        {
            if (cb_MeresType.SelectedIndex == 0) //bent
            {
                nud_Csapadek.Enabled = false;
                nud_Legnyomas.Enabled = false;
                nud_Harmatpont.Enabled = true;
                if (currentM.Harmatpont != null)
                {
                    nud_Harmatpont.Value = (decimal)currentM.Harmatpont;
                }
                merestype = "bent";

            }
            else // kint
            {
                nud_Harmatpont.Enabled = false;
                nud_Csapadek.Enabled = true;
                nud_Legnyomas.Enabled = true;
                if (currentM.Csapadek != null && currentM.Legnyomas != null)
                {
                    nud_Csapadek.Value = (decimal)currentM.Csapadek;
                    nud_Legnyomas.Value = (decimal)currentM.Legnyomas;
                }
                merestype = "kint";

            }
        }

        
        private void FillComb()
        {
            cb_MeresType.Items.Add("Benti");
            cb_MeresType.Items.Add("Külső");

            if (currentM.MeroType == "Bent")
            {
                cb_MeresType.SelectedIndex = 0;
            }
            else
            {
                cb_MeresType.SelectedIndex = 1;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_MeresType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeSwitcher();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan módosítani szeretnéd?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                uLogic.EditMeres(currentM, merestype, dtp_Meres.Value, (double)nud_Homerseklet.Value, (double)nud_Harmatpont.Value, (double)nud_Legnyomas.Value, (double)nud_Csapadek.Value);
                MessageBox.Show("Sikeres módosítás!", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretnéd?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                uLogic.DeleteMeres(currentM);
                MessageBox.Show("Sikeres törlés!", "Törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
