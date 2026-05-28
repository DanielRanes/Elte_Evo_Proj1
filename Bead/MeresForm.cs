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
using Microsoft.VisualBasic.ApplicationServices;

namespace Bead.Forms
{
    public partial class MeresForm : Form
    {
        bool benti;
        User currentUser;
        UserLogic uLogic;
        public MeresForm(User user, bool KintVBent)
        {
            uLogic = new();
            currentUser = user;
            benti = KintVBent;
            InitializeComponent();
            SetDateTimeProps();
            SetNUDs();
            ShowSwitchMeres(KintVBent);
        }
        private void SetNUDs()
        {
            nud_Homerseklet.DecimalPlaces = 2;
            nud_HarmatPont.DecimalPlaces = 2;
            nud_Legnyomas.DecimalPlaces = 2;
            nud_Csapadek.DecimalPlaces = 2;
        }
        private void SetDateTimeProps()
        {
            datepicker.Format = DateTimePickerFormat.Custom;
            datepicker.CustomFormat = "yyyy-MM-dd HH:mm";
            datepicker.ShowUpDown = true;
        }

        private void ShowSwitchMeres(bool bent)
        {
            if (bent)
            {
                //csapadék, légnyomás NULL
                nud_Csapadek.Visible = false;
                nud_Legnyomas.Visible = false;
                lbl_csapadek.Visible = false;
                lbl_legnyomas.Visible = false;
                lbl_bent.Text = "Benti mérés";

            }
            else
            {
                // harmatpont NULL
                nud_HarmatPont.Visible = false;
                lbl_harmatpont.Visible = false;
                lbl_bent.Text = "Külső mérés";
            }
        }
        private void SaveMeres()
        {
            uLogic.SavingMeres(benti, currentUser, datepicker.Value, (double)nud_Homerseklet.Value, (double)nud_HarmatPont.Value, (double)nud_Legnyomas.Value, (double)nud_Csapadek.Value);
            MessageBox.Show("Adatok sikeresen rögzítve az adatbázisba!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SaveData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos menteni szeretnéd a mérés? Minden adat helyes?", "Mentés megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveMeres();
            }
            
        }
    }
}
