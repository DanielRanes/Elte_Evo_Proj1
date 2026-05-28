using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using Bead.Logics;
using Bead.Models;
using System.IO; // exporthoz

namespace Bead.Forms
{
    public partial class UserSite : Form
    {
        User currentUser;
        UserLogic uLogic;
        double atlagH;

        public UserSite(User user)
        {
            uLogic = new UserLogic();
            currentUser = user;

            InitializeComponent();

            SetUpForm();
            RefreshForm();
        }

        private void SetUpForm()
        {
            dg_meresek.AutoGenerateColumns = false;

            lbl_welcome.Text = $"Üdv {currentUser.Name} ({currentUser.UserType})";

            SetDateTimeProp();
            FillCombM();
            SetUpColumns();

            // SZÍNEZÉS HOZZÁKÖTÉSE
            dg_meresek.CellFormatting += dg_meresek_CellFormatting;
        }

        private void RefreshForm()
        {

            RefreshDG();
            AverageTemperature();
        }

        private void FillCombM()
        {
            cb_InOrOut.Items.Add("Benti");
            cb_InOrOut.Items.Add("Külső");
            cb_InOrOut.Items.Add("Összes");

            cb_Types.Items.Add("Saját");
            cb_Types.Items.Add("Többi");
            cb_Types.Items.Add("Összes");

            cb_InOrOut.SelectedIndex = 2;
            cb_Types.SelectedIndex = 2;
        }

        private void SetDateTimeProp()
        {
            datepicker1.Format = DateTimePickerFormat.Custom;
            datepicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            datepicker1.ShowUpDown = true;
            datepicker1.Value = new DateTime(DateTime.Now.Year - 1, 1, 1, 0, 0, 0);

            datepicker2.Format = DateTimePickerFormat.Custom;
            datepicker2.CustomFormat = "yyyy-MM-dd HH:mm";
            datepicker2.ShowUpDown = true;
            datepicker2.Value = DateTime.Now;
        }

        private void RefreshDG()
        {
            dg_meresek.DataSource = uLogic.FillUserDG(
                datepicker1.Value,
                datepicker2.Value,
                cb_InOrOut.SelectedItem?.ToString(),
                cb_Types.SelectedItem?.ToString(),
                currentUser.Id
            );
        }

        private void SetUpColumns()
        {
            dg_meresek.Columns["MeroId"].DataPropertyName = "MeroId";
            dg_meresek.Columns["MeroDatum"].DataPropertyName = "Date";
            dg_meresek.Columns["MeroType"].DataPropertyName = "MeroType";
            dg_meresek.Columns["MeroHomerseklet"].DataPropertyName = "Homerseklet";
            dg_meresek.Columns["MeroHarmatPont"].DataPropertyName = "HarmatPont";
            dg_meresek.Columns["MeroParatartalom"].DataPropertyName = "Paratartalom";
            dg_meresek.Columns["MeroLegnyomas"].DataPropertyName = "Legnyomas";
            dg_meresek.Columns["MeroCsapadek"].DataPropertyName = "Csapadek";
        }

        // NAPI MAX SZÍNEZÉS
        private void dg_meresek_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // ha üres
            if (e.RowIndex < 0)
            {
                return;
            }
            // soronként végigmegyünk, és ha a sorhoz tartozó adatban a napi max érték
            DataGridViewRow row = dg_meresek.Rows[e.RowIndex];

            if (row.DataBoundItem is ViewData data)
            {
                if (data.IsDailyMax)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void AverageTemperature()
        {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dg_meresek.Rows)
            {
                if (!row.IsNewRow && row.Cells["MeroHomerseklet"].Value != null)
                {
                    double temp;

                    if (double.TryParse(row.Cells["MeroHomerseklet"].Value.ToString(), out temp))
                    {
                        sum = sum + temp;
                        count = count + 1;
                    }
                }
            }

            if (count > 0)
            {
                tb_Average.Text = Math.Round(sum / count, 2).ToString();
                atlagH = Math.Round(sum / count, 2);
            }
            else
            {
                tb_Average.Text = "nincs";
            }
        }

        #region Buttons

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NewMeres_Click(object sender, EventArgs e)
        {
            bool InsideOrOutside;

            In_Out_Form ioForm = new In_Out_Form();

            if (ioForm.ShowDialog() == DialogResult.Yes)
            {
                InsideOrOutside = false;
            }
            else
            {
                InsideOrOutside = true;
            }

            MeresForm UjMeres = new(currentUser, InsideOrOutside);
            UjMeres.ShowDialog();
            datepicker2.Value = DateTime.Now;
            RefreshForm();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_GotoOwnMeres_Click(object sender, EventArgs e)
        {
            OwnMeresekForm OF = new(currentUser);
            OF.ShowDialog();
            datepicker2.Value = DateTime.Now;
            RefreshForm();
        }

        private void btn_USaveXML_Click(object sender, EventArgs e)
        {
            UExportData export;
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "XML fájl (*.xml)|*.xml";
            sfd.FileName = $"{currentUser.Name}_{currentUser.UserType}_XSaves.xml";

            // Először hely kiválasztása
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (uLogic.USavingXML(datepicker1.Value, datepicker2.Value, currentUser, atlagH) != null)
                    {
                        export = uLogic.USavingXML(datepicker1.Value, datepicker2.Value, currentUser, atlagH);
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(UExportData)); // magát az osztályt teszembe a paraméterbe
                            xs.Serialize(sw, export);
                        }
                        MessageBox.Show("Sikeres XML mentés!", "XML Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(uLogic.ErrorM, "XML Mentés HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion
    }
}