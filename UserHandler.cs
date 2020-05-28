using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;

namespace geztoz_asp
{
    public class User
    {
        private string id;
        private string name;
        private string surname;
        private string email;
        private string password;
        private string travelsId ="";

        public static User user;

       
        public string Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname= value;
        }
        public string Email
        {
            get => email;
            set => email= value;
        }
        public string Password
        {
            get => password;
            set => password= value;
        }
        public string TravelsId
        {
            get => travelsId;
            set => travelsId += value + "-";
        }

        public void setNull()
        {
            user = null;
        }

        private User(string id, string name, string surname, string email, string password, string travelsId = "")
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.travelsId = travelsId;
        }

        public static User getInitial(string id = "", string name = "", string surname = "", string email = "", string password = "", string travelsId = "")
        {
            if (user == null)
            {
                user = new User(id, name, surname, email, password, travelsId);
                return user;
            }
            else
            {
                return user;
            }
        }
    }
    
    public class UserHandler
    {
        private DatabaseHandler dh = DatabaseHandler.getInitial();
        static List<User> userList = new List<User>();
        static UserHandler userHandler;
        private bool isValid =false;
        private UserHandler() { }

        public void setNull()
        {
            userHandler = null;
        }

        public static UserHandler getInitial()
        {
            if (userHandler == null)
            {
                 userHandler = new UserHandler();
                 return userHandler;
            }
            else
            {
                return userHandler;
            }
        }

     
        // Register User Section

        public void registerUser(string name, string surname, string email, string password)
        {
            isValid = Validation.validateRegisterUserInputsEmpty(name, surname, email, password);
            if (isValid)
            {
                User user = User.getInitial(generateUserId(),name, surname, email, password);
                userList.Add(user);
                dh.addUser(user);
                isValid = false;
            }
        }

        private string generateUserId()
        {
            string id = "user-";
            Random random = new Random();
            int randomNumber = random.Next(1, 1000000);
            id += randomNumber.ToString();
            isValid = Validation.validateUserId(id, userList);
            if (isValid)
            {
                return id;
            }
            else
            {
                return generateUserId();
            }
        }

        //Login Section

        public bool loginUser(string loginEmail, string loginPassword)
        {
            if (Validation.validateLogin(loginEmail, loginPassword))
            {
                User user = dh.getUser(loginEmail);
                return true;
            }
            else
            {
                return false;
            }
           
        }

        

    }
}