using System.Collections.Generic;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace geztoz_asp
{
    public class Validation
    {
        public Validation(){}
        static DatabaseHandler dh = DatabaseHandler.getInitial();

        // Sign Up Validation Section
        // validateEmpty signup sayfasındaki inputların boş olma durumunu veya girilen mail adresinin daha önce kullanılmış olma durumunu test ediyor.
        // validateVerifyPassword üye olurken girilen şifreler bir biri ile uyuşuyor mu onu test ediyor.
        // validateUserId userId üretiyor.

        public static bool validateEmpty(string name, string surname, string email, string password, List<User> list)
        {
            if (name == "" || surname == "" || email == "" || password == "")
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.");
                return false;
            }
            if (list.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (var targetUser in list)
                {
                    if (email == targetUser.Email)
                    {
                        MessageBox.Show("Bu mail daha önce kullanılmış.");
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool validateVerifyPassword(string pass, string verifyPass)
        {
            return  pass == verifyPass ? true : false;
        }

        public static bool validateUserId(string id, List<User> list)
        {
            foreach (var targetUser in list)
            {
                if (id == targetUser.Id)
                {
                    return false;
                }
            }

            return true;
        }

        // Login Section

        public static bool validateLogin(string email,string password)
        {
            List<string> emailsList = dh.getEmailsList();

            foreach (var item in emailsList)
            {
                if (item == email)
                {
                    var pass = dh.getPasswordForAnEmail(item);
                    if (pass == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //private static bool validateLoginPassword(string email, string password)
        //{
            
        //}
    }
}