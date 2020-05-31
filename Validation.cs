using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace geztoz_asp
{
    public class Validation
    {
        public Validation(){}
        static DatabaseHandler dh = DatabaseHandler.getInitial();

        // Sign Up Validation Section
        // validateRegisterUserInputsEmpty signup sayfasındaki inputların boş olma durumunu veya girilen mail adresinin daha önce kullanılmış olma durumunu test ediyor.
        // validateVerifyPassword üye olurken girilen şifreler bir biri ile uyuşuyor mu onu test ediyor.
        // validateUserId userId üretiyor.

        public static bool validateEmailIsAvailable(string email)
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

        public static bool validateRegisterUserInputsEmpty(string name, string surname, string email, string password)
        {
            if (name == "" || surname == "" || email == "" || password == "")
            {
                return false;
            }
           
            else
            {
                if (Validation.validateEmailIsAvailable(email))
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

        public static bool validateTravelRegisterInputsEmpty(string driverName, string driverSurname, string fromDestination, string toDestination)
        {
            if (driverName == "" || driverSurname == "" || fromDestination == "" || toDestination == "")
            {
                return false;
            }

            return true;
        }

        public static bool validateTravelDate(DateTime travelDate)
        {
            if (travelDate.Date <= DateTime.Now)
            {
                return false;
            }

            return true;
        }

        public static bool validateSeat(int totalSeat, int availableSeat)
        {
            if (totalSeat <= 0)
            {
                return false;
            }

            if (availableSeat < 0 )
            {
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
                    return false;
                }
            }

            return true;
        }

        //Show Travels Section (Search.aspx kısmı)
        public static bool validateTravelSearchInputsEmpty(string from, string to, int wantedSeat)
        {
            if (from == "" || to == "" || wantedSeat <= 0)
            {
                return false;
            }

            return true;
        }
        
        public static bool validateWantedSeat(int wantedSeat)
        {
            return wantedSeat > 0 ? true : false;
        }

        public static bool validateIsPassengerAlreadySignUpForCertainTravel(string existPassengersIds, string newPassengerId,string driverId)
        {
            string[] existPassengersIdsArray = existPassengersIds.Split('/');
            foreach (var passengerId in existPassengersIdsArray)
            {
                if (newPassengerId == passengerId || newPassengerId == driverId)
                {
                    return false;
                }
            }

            return true;
        }

    }
}