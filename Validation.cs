using System;
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
        // validateRegisterUserEmpty signup sayfasındaki inputların boş olma durumunu veya girilen mail adresinin daha önce kullanılmış olma durumunu test ediyor.
        // validateVerifyPassword üye olurken girilen şifreler bir biri ile uyuşuyor mu onu test ediyor.
        // validateUserId userId üretiyor.

        public static bool validateRegisterUserEmpty(string name, string surname, string email, string password)
        {
            if (name == "" || surname == "" || email == "" || password == "")
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.");
                return false;
            }
           
            else
            {
                List<string> emailList = dh.getEmailsList();
                if (emailList.Contains(email))
                {
                    return false;
                }
                else
                {
                    return true;
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

            if (email == "" || password == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }

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


        //Travel add section. 

        public static bool validateRegisterTravelEmpty(string driverName, string driverSurname, string fromDestination, string toDestination)
        {
            if (driverName == "" || driverSurname == "" || fromDestination == "" || toDestination == "")
            {
                MessageBox.Show("Tüm alanlar dolu olmalıdır.");
                return false;
            }

            return true;
        }

        public static bool validateTravelDate(DateTime travelDate)
        {
            if (travelDate.Date <= DateTime.Now)
            {
                MessageBox.Show("Lütfen geçerli bir tarih girin!");
                return false;
            }

            return true;
        }

        public static bool validateSeat(int totalSeat, int availableSeat)
        {
            if (totalSeat <= 0)
            {
                MessageBox.Show("Kişi sayısı en az 1 olmalı");
                return false;
            }

            if (availableSeat >= totalSeat)
            {
                MessageBox.Show("Tüm koltuklar dolu!");
                return false;
            }

            return true;
        }

        public static bool validateTravelId(string travelId)
        {
            List<string> travelIdList = dh.getAllTravelIds();
            foreach (var id in travelIdList)
            {
                if (travelId == id)
                {
                    MessageBox.Show("Bu yolculuk zaten daha önce eklenmiş.");
                    return false;
                }
            }

            return true;
        }



    }
}