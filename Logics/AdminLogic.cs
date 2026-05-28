using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bead;
using Bead.Models;

namespace Bead.Logics
{
    public class AdminLogic
    {
        public string ErrorMessage { get; set; }
        
        public void ModifyUserDB(User user, string username, string originalName, int RankType)
        {
            if (CheckUsername(username, originalName))
            {
                using (Bead_Database db = new Bead_Database())
                {
                    var userInDb = db.Users.FirstOrDefault(u => u.Id == user.Id);
                    if (userInDb != null)
                    {
                        userInDb.Name = username;
                        userInDb.UserType = RankSwitch(RankType);
                        db.SaveChanges();
                    }
                }
            }
        }
        public void DeleteUserDB(User user)
        {
            using (Bead_Database db = new Bead_Database())
            {
                User userInDb = db.Users.FirstOrDefault(u => u.Id == user.Id);
                if (userInDb != null)
                {
                    db.Users.Remove(userInDb);
                    db.SaveChanges();
                }
            }
        }
        public List<AExportData> AdminXMLSaving(DateTime date, User cUser)
        {
            UserLogic uLogic = new UserLogic();

            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime weekStart = date.AddDays(-diff).Date;
            DateTime weekEnd = weekStart.AddDays(7);

            List<ViewData> kulsoMeresek = uLogic.FillUserDG(
                weekStart,
                weekEnd,
                "Külső",
                "Összes",
                cUser.Id
            ).ToList();

            if (kulsoMeresek.Count == 0)
            {
                ErrorMessage = "Nincs exportálható adat!";
                return null;
            }

            List<AExportData> hetiLista = new List<AExportData>();

            double osszeg = 0;
            int db = 0;

            foreach (ViewData item in kulsoMeresek)
            {
                if (item.Legnyomas.HasValue)
                {
                    osszeg += item.Legnyomas.Value;
                    db++;
                }
            }

            if (db > 0)
            {
                AExportData adat = new AExportData();
                adat.WeekStart = weekStart;
                adat.WeekEnd = weekEnd;
                adat.AtlagLegnyomas = Math.Round(osszeg / db, 2);

                hetiLista.Add(adat);
            }
            return hetiLista;
        }

        public List<SingleUser> FillAllUserList()
        {
            using (Bead_Database db = new Bead_Database())
            {
                List<SingleUser> lista = (
                  from u in db.Users
                  select new SingleUser
                  {
                      UserID = u.Id,
                      Username = u.Name,
                      UserRank = u.UserType
                  }
                ).ToList();
                return lista;
            }
        }

        private string RankSwitch(int num)
        {
            if (num == 0)
            {
                return "User";
            }
            return "SuperAdmin";
        }

        private bool CheckUsername(string felhaszN, string originalName)
        {
            string errorM = "";
            int isexistN = 0;
            ErrorMessage = "";

            using (Bead_Database db = new())
            {
                foreach (User u in db.Users)
                {
                    if (originalName != felhaszN && u.Name == felhaszN)
                    {
                        isexistN += 1;
                        
                    }
                }
            }

            if (felhaszN == null || felhaszN == "")
            {
                errorM = "- Nem adtál meg felhasználónevet!";
                ErrorMessage = errorM;
                return false;
            }
            else if (felhaszN.Length < 6)
            {
                errorM = "- Nem elég hosszú a felhasználónév! (legalább 6 karakter)";
                ErrorMessage = errorM;
                return false;
            }
            else if (felhaszN.Length > 20)
            {
                errorM = "- Túl hosszú a felhasználónév! (max 20 karakter)";
                ErrorMessage = errorM;
                return false;
            }
            // is any char digit
            else if (felhaszN.Any(char.IsDigit))
            {
                errorM = "- A felhasználónév nem tartalmazhat számot!";
                ErrorMessage = errorM;
                return false;
            }
            else if (isexistN >= 1)
            {
                errorM = "- Felhasználó már létezik";
                ErrorMessage = errorM;
                return false;
            }
            return true;
        }
    }
}
