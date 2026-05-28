using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Bead.Models;
using Bead;

namespace Bead.Logics
{
    public class UserLogic
    {
        #region UserSITE
        public string ErrorM { get; set; }
        public List<ViewData> FillUserDG(DateTime fromDate, DateTime toDate, string type, string owner, int currentUserId)
        {
            using (Bead_Database datab = new Bead_Database())
            {
                List<Meresek> list = datab.Mereseks.ToList();

                // dátum szűrés
                List<Meresek> filteredList = new List<Meresek>();

                foreach (Meresek m in list)
                {
                    if (m.Date >= fromDate)
                    {
                        if (m.Date <= toDate)
                        {
                            filteredList.Add(m);
                        }
                    }
                }

                list = filteredList;

                // típus szűrés
                filteredList = new List<Meresek>();

                foreach (Meresek m in list)
                {
                    if (type == "Benti")
                    {
                        if (m.MeroType == "Bent")
                        {
                            filteredList.Add(m);
                        }
                    }
                    else
                    {
                        if (type == "Külső")
                        {
                            if (m.MeroType == "Kint")
                            {
                                filteredList.Add(m);
                            }
                        }
                        else
                        {
                            filteredList.Add(m);
                        }
                    }
                }

                list = filteredList;

                // owner szűrés
                filteredList = new List<Meresek>();

                foreach (Meresek m in list)
                {
                    if (owner == "Saját")
                    {
                        if (m.MeroId == currentUserId)
                        {
                            filteredList.Add(m);
                        }
                    }
                    else
                    {
                        if (owner == "Többi")
                        {
                            if (m.MeroId != currentUserId)
                            {
                                filteredList.Add(m);
                            }
                        }
                        else
                        {
                            filteredList.Add(m);
                        }
                    }
                }

                list = filteredList;

                // view "konvertálás"
                List<ViewData> viewList = new List<ViewData>();

                foreach (Meresek m in list)
                {
                    ViewData v = new ViewData();

                    v.MeroId = m.MeroId;

                    if (m.MeroType == "Bent")
                    {
                        v.MeroType = "Belső";
                    }
                    else
                    {
                        v.MeroType = "Külső";
                    }

                    v.Homerseklet = m.Homerseklet;
                    v.HarmatPont = m.Harmatpont;
                    v.Legnyomas = m.Legnyomas;
                    v.Csapadek = m.Csapadek;
                    v.Date = m.Date;

                    if (m.Harmatpont != null)
                    {
                        double hp = m.Harmatpont.Value;
                        v.Paratartalom = 100 - 5 * (m.Homerseklet - hp);
                    }
                    else
                    {
                        v.Paratartalom = null;
                    }

                    v.IsDailyMax = false;

                    viewList.Add(v);
                }

                // NAPI MAX LOGIKA
                List<ViewData> finalList = new List<ViewData>();

                foreach (ViewData current in viewList)
                {
                    DateTime currentDay = current.Date.Date;

                    double max = current.Homerseklet;

                    // megkeressük a napi maximumot
                    foreach (ViewData item in viewList)
                    {
                        if (item.Date.Date == currentDay)
                        {
                            if (item.Homerseklet > max)
                            {
                                max = item.Homerseklet;
                            }
                        }
                    }

                    // beállítjuk, hogy ez-e a max
                    if (current.Homerseklet == max)
                    {
                        current.IsDailyMax = true;
                    }
                    else
                    {
                        current.IsDailyMax = false;
                    }
                    finalList.Add(current);
                }
                return finalList;
            }
        }

        public List<SingleMeres> FillOwnMeresekList(User CurrentUser)
        {
            using (Bead_Database db = new Bead_Database())
            {
                List<SingleMeres> lista = (
                    from m in db.Mereseks
                    where m.MeroId == CurrentUser.Id
                    select new SingleMeres
                    {
                        MeresId = m.Id,
                        MeresType = m.MeroType,
                        MeresDate = m.Date,
                        MeresHomerseklet = m.Homerseklet,
                        MeresHarmatpont = m.Harmatpont,
                        MeresLegnyomas = m.Legnyomas,
                        MeresCsapadek = m.Csapadek
                    }
                ).ToList();
                return lista;
            }
        }

        public UExportData USavingXML(DateTime fromT, DateTime toT, User cUser, double atlagHom)
        {
            List<ViewData> kulsoMeresek = FillUserDG(
                fromT,
                toT,
                "Külső",
                "Összes",
                cUser.Id
            ).ToList();

            if (kulsoMeresek.Count == 0)
            {
                ErrorM = "Nincs exportálható adat!";
                return null;
            }

            // Átlagcsapadék számítása
            double osszCsapadek = 0;

            foreach (ViewData item in kulsoMeresek)
            {
                if (item.Csapadek.Value != null)
                {
                    osszCsapadek += item.Csapadek.Value;
                }
            }

            double atlagCsapadek = osszCsapadek / kulsoMeresek.Count;

            UExportData export = new UExportData()
            {
                Tol = fromT,
                Ig = toT,
                AtlagHomerseklet = Math.Round(atlagHom, 2),
                AtlagCsapadek = Math.Round(atlagCsapadek, 2)
            };
            return export;
        }
        #endregion

        #region ADDMeres
        public void SavingMeres(bool bent, User user, DateTime MeresDate, double homerseklet, double harmatpont, double legnyomas, double csapadek)
        {
            string kintVbent;
            if (bent)
            {
                kintVbent = "Bent";
                AddBelso(kintVbent, user, MeresDate, homerseklet, harmatpont);
            }
            else
            {
                kintVbent = "Kint";
                AddKulso(kintVbent, user, MeresDate, homerseklet, legnyomas, csapadek);
            }
        }
        private void AddKulso(string kintVbent, User user, DateTime MeresDate, double homerseklet, double legnyomas, double csapadek)
        {
            using (Bead_Database db = new Bead_Database())
            {
                Meresek Meres = new Meresek()
                {
                    MeroId = user.Id,
                    MeroType = kintVbent,
                    Date = MeresDate,
                    Homerseklet = homerseklet,
                    Harmatpont = null,
                    Legnyomas = legnyomas,
                    Csapadek = csapadek,

                };

                db.Mereseks.Add(Meres);
                db.SaveChanges();
            }
        }

        private void AddBelso(string kintVbent, User user, DateTime MeresDate, double homerseklet, double harmatpont)
        {
            using (Bead_Database db = new Bead_Database())
            {

                Meresek Meres = new Meresek()
                {
                    MeroId = user.Id,
                    MeroType = kintVbent,
                    Date = MeresDate,
                    Homerseklet = homerseklet,
                    Harmatpont = harmatpont,
                    Legnyomas = null,
                    Csapadek = null,

                };

                db.Mereseks.Add(Meres);
                db.SaveChanges();
            }
        }
        #endregion
        #region EDITMeres
        public Meresek FindCurrentMeres(int mId)
        {
            using (Bead_Database db = new Bead_Database())
            {
                Meresek meres = db.Mereseks.FirstOrDefault(m => m.Id == mId);
                return meres;
            }
        }
        public void EditMeres(Meresek CurrentM, string merestype, DateTime date, double homerseklet, double harmatpont, double legnyomas, double csapadek)
        {
            using (Bead_Database db = new Bead_Database())
            {
                Meresek meres = null;

                foreach (Meresek m in db.Mereseks) // megkeresi a megfelelő merest
                {
                    if (m.Id == CurrentM.Id)
                    {
                        meres = m;
                        break;
                    }
                }

                // alap adatok
                if (merestype == "bent")
                {
                    meres.MeroType = "Bent";
                    meres.Legnyomas = null;
                    meres.Csapadek = null;
                    meres.Harmatpont = harmatpont;
                }
                else
                {
                    meres.MeroType = "Kint";
                    meres.Harmatpont = null;
                    meres.Csapadek = csapadek;
                    meres.Legnyomas = legnyomas;
                }

                meres.Date = date;
                meres.Homerseklet = homerseklet;

                db.SaveChanges();
            }
        }
        public void DeleteMeres(Meresek currentM)
        {
            using (Bead_Database db = new Bead_Database())
            {
                Meresek meres = db.Mereseks.FirstOrDefault(m => m.Id == currentM.Id);
                db.Mereseks.Remove(meres);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
