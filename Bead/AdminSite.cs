using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Charts
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using Bead.Logics;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

using Bead.Models;

namespace Bead.Forms
{
    public partial class AdminSite : Form
    {
        User currentUser;
        AdminLogic aLogic;
        public AdminSite(User user)
        {
            currentUser = user;
            aLogic = new();
            InitializeComponent();
            SetDateTimeProp();
            lbl_userW.Text = $"Üdv, {currentUser.Name} ({currentUser.UserType})";
            VonalChartMaker(dtp1.Value, dtp2.Value);
        }
        private void SetDateTimeProp()
        {
            dtp1.Value = new DateTime(DateTime.Now.Year - 1, 1, 1);
            dtp2.Value = DateTime.Now;
        }
        #region grafok

        private double ParatartalomCount(IEnumerable<Meresek> g)
        {
            double osszeg = 0;
            int db = 0;

            foreach (var m in g)
            {
                double harmatpont;

                if (m.Harmatpont.HasValue)
                {
                    harmatpont = m.Harmatpont.Value;
                }
                else
                {
                    harmatpont = m.Homerseklet;
                }

                osszeg += 100 - 5 * (m.Homerseklet - harmatpont);
                db++;
            }

            if (db > 0)
            {
                return osszeg / db;
            }

            return 0;
        }
        private void VonalChartMaker(DateTime from, DateTime to)
        {
            from = from.Date;
            to = to.Date;

            Chart chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            ChartArea area = new ChartArea
            {
                BackColor = Color.White
            };
            area.AxisX.LabelStyle.Format = "yyyy-MM-dd";

            TimeSpan duration = to - from;
            if (duration.TotalDays <= 21)
            {
                area.AxisX.IntervalType = DateTimeIntervalType.Days;
                area.AxisX.Interval = 1;
            }
            else
            {
                area.AxisX.IntervalType = DateTimeIntervalType.Auto;
            }

            // Olvashatóság
            area.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;

            // Y tengely
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 100;
            area.AxisY.Interval = 10;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart.ChartAreas.Add(area);

            Series series = new Series
            {
                ChartType = SeriesChartType.Line, // Vonal
                XValueType = ChartValueType.Date, // x tengely adattípus
                BorderWidth = 3,
                Color = Color.DodgerBlue,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                MarkerColor = Color.Red
            };

            using (Bead_Database db = new Bead_Database())
            {
                List<Meresek> rawData = db.Mereseks
                    .Where(m => m.Date >= from && m.Date <= to.AddDays(1))
                    .OrderBy(m => m.Date)
                    .ToList();

                if (rawData.Any())
                {
                    var dailyData = rawData
                        .GroupBy(m => m.Date.Date)
                        .Select(g => new
                        {
                            Nap = g.Key,
                            Paratartalom = ParatartalomCount(g)
                        })
                        .ToList();

                    area.AxisX.Minimum = dailyData.Min(d => d.Nap).ToOADate();
                    area.AxisX.Maximum = dailyData.Max(d => d.Nap).ToOADate();

                    foreach (var d in dailyData)
                    {
                        double p = d.Paratartalom;

                        if (p < 0)
                        {
                            p = 0;
                        }
                        if (p > 100)
                        {
                            p = 100;
                        }

                        series.Points.AddXY(d.Nap, p);
                    }
                }
            }

            chart.Series.Add(series);
            chart.Titles.Add("Páratartalom alakulása");

            tp_Vonal.Controls.Clear();
            tp_Vonal.Controls.Add(chart);
            tc_Grafs.SelectedTab = tp_Vonal;
        }

        private void KorChartMaker(DateTime selectedDate)
        {
            // Hét kezdete (hétfő)
            int diff = (7 + (selectedDate.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime weekStart = selectedDate.AddDays(-1 * diff).Date;
            DateTime weekEnd = weekStart.AddDays(7);

            Chart chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie, // kördiagram
                IsValueShownAsLabel = true,
                LabelFormat = "0.##'%'" // 2 tizedes %-os kiírás
            };

            using (Bead_Database db = new Bead_Database())
            {
                List<Meresek> data = (
                    from m in db.Mereseks
                    where m.Date >= weekStart
                          && m.Date < weekEnd
                          && m.MeroType == "Kint"
                    select m
                ).ToList();

                if (data.Any())
                {
                    // Hőmérséklet kategóriák
                    var groups = data.GroupBy(m =>
                    {
                        if (m.Homerseklet < 5) return "0-5°C";
                        if (m.Homerseklet < 10) return "5-10°C";
                        if (m.Homerseklet < 15) return "10-15°C";
                        if (m.Homerseklet < 20) return "15-20°C";
                        if (m.Homerseklet < 25) return "20-25°C";
                        if (m.Homerseklet < 30) return "25-30°C";
                        if (m.Homerseklet < 35) return "30-35°C";
                        if (m.Homerseklet < 40) return "35-40°C";
                        return "40°C+";
                    })
                    .Select(g => new
                    {
                        Category = g.Key,
                        Count = g.Count()
                    })
                    .ToList();

                    int total = groups.Sum(g => g.Count);

                    foreach (var g in groups)
                    {
                        double percent = (double)g.Count / total * 100;

                        int index = series.Points.AddXY(g.Category, percent);

                        series.Points[index].Label =
                            $"{g.Category}\n{g.Count} db\n{percent:0.##}%";

                        series.Points[index].LegendText = g.Category;
                    }
                }
            }

            chart.Series.Add(series);
            chart.Titles.Add($"Hőmérséklet megoszlás (hét: {weekStart:yyyy-MM-dd})");

            tp_Kor.Controls.Clear();
            tp_Kor.Controls.Add(chart);
            tc_Grafs.SelectedTab = tp_Kor;
        }
        #endregion

        #region Buttons
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CircleR_Click(object sender, EventArgs e)
        {
            KorChartMaker(dtp3.Value);
        }

        private void btn_LineR_Click(object sender, EventArgs e)
        {
            VonalChartMaker(dtp1.Value, dtp2.Value);
        }

        private void btn_userM_Click(object sender, EventArgs e)
        {
            AllUserM AUForm = new AllUserM(currentUser);
            AUForm.ShowDialog();
        }

        private void btn_AXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "XML fájl (*.xml)|*.xml";
            sfd.FileName = $"{currentUser.Name}{currentUser.UserType}_XSaves.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<AExportData> hetiLista = aLogic.AdminXMLSaving(dtp3.Value, currentUser);
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(List<AExportData>));
                        xs.Serialize(sw, hetiLista);
                    }

                    MessageBox.Show("Sikeres heti XML export!");
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
