using System;
using System.Collections.Generic;
using System.Linq;
//Hash-hez
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Bead.Logics
{
    public class AuthService
    {
        public string ErrorMessage { get; set; }
        public User LogicCurrentUser { get; set; }

        public AuthService(User user)
        {
            LogicCurrentUser = user;
        }

        public AuthService()
        {
            
        }
        // ÁTNÉZNI !!!
        public string HashPassword(string password)
        {
            byte[] hashedPW = SHA512.HashData(Encoding.UTF8.GetBytes(password));

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashedPW)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        #region LOGIN
        public bool CheckLogin(string LoginUserN, string LoginPW)
        {
            bool isexists = false;
            bool iscorrect = false;


            if (LoginUserN == null || LoginUserN.Trim() == "" || LoginPW == null || LoginPW.Trim() == "")
            {
                ErrorMessage = "- Nem adtál meg felhasználónevet vagy jelszót!";
                return false;
            }
            else
            {
                using (Bead_Database db = new Bead_Database())
                {
                    foreach (User user in db.Users)
                    {
                        if (LoginUserN.Trim() == user.Name)
                        {
                            isexists = true;
                            if (user.Password == HashPassword(LoginPW))
                            {
                                iscorrect = true;
                                LogicCurrentUser = user;
                            }
                            break;
                        }
                    }
                }

                if (!isexists)
                {
                    ErrorMessage = "A felhasználó nem létezik.";
                    return false;
                }
                else if (!iscorrect)
                {
                    ErrorMessage = "A jelszó nem jó.";
                    return false;
                }
                return true;
            }

        }
        #endregion
        #region REGIST
        public bool CheckUsername(string felhaszN)
        {
            string errorM = "";
            bool isexists = false;

            using (Bead_Database db = new())
            {
                foreach (User u in db.Users)
                {
                    if (u.Name == felhaszN)
                    {
                        isexists = true;
                        break;
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
            else if (isexists)
            {
                errorM = "- Felhasználó már létezik";
                ErrorMessage = errorM;
                return false;
            }
            return true;
        }
        private bool CheckPS(string felhaszN, string jelszo1, string jelszo2)
        {
            string errorM = "";
            if (jelszo1 != jelszo2)
            {
                errorM = "- A jelszavak nem egyeznek!";
                ErrorMessage += $"\n{errorM}";
                return false;
            }
            else
            {
                if (jelszo1 == null || jelszo1.Trim() == "" || jelszo2 == null || jelszo2.Trim() == "")
                {
                    errorM = "- Nem adtál meg jelszót!";
                    ErrorMessage = errorM;
                    return false;
                }
                else if (jelszo1.Length < 8)
                {
                    errorM = "- A jelszó rövidebb mint 8 karakter!";
                    ErrorMessage += $"\n{errorM}";
                    return false;
                }
                else if (jelszo1.Length > 30)
                {
                    errorM = "- A jelszó hoszabb mint 30 karakter!";
                    ErrorMessage += $"\n{errorM}";
                    return false;
                }
            }
            return true;
        }
        public bool AddUser(string felhaszN, string jelszo, string jelszo2)
        {
            if (CheckUsername(felhaszN) && CheckPS(felhaszN, jelszo, jelszo2))
            {
                using (Bead_Database db = new Bead_Database())
                {
                    User newUser = new User()
                    {
                        Name = felhaszN.Trim(),
                        Password = HashPassword(jelszo),
                        UserType = "User"
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
                return true;
            }
            return false;
        }

        public bool AddAdmin(string felhaszN, string jelszo, string jelszo2)
        {
            if (CheckUsername(felhaszN) && CheckPS(felhaszN, jelszo, jelszo2))
            {
                using (Bead_Database db = new Bead_Database())
                {
                    User newUser = new User()
                    {
                        Name = felhaszN.Trim(),
                        Password = HashPassword(jelszo),
                        UserType = "SuperAdmin"
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
                return true;
            }
            return false;
        }
        #endregion
    }
}
