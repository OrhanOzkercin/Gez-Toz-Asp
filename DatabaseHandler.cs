using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace geztoz_asp
{
    
    public class DatabaseHandler
    {
        private static OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\egil_\Desktop\proje_asp\geztoz_asp\geztoz_asp\App_Data\main.mdb;Persist Security Info=True");
        private static DatabaseHandler dh;
        private DatabaseHandler(){}

        public static DatabaseHandler getInitial()
        {
            if (dh == null)
            {
                dh = new DatabaseHandler();
                return dh;
            }
            else
            {
                return dh;
            }
        }

        public List<string> getEmailsList()
        {
            List<string> emailList = new List<string>();
            OleDbCommand select = new OleDbCommand("Select email from Users ", conn);
            conn.Open();
            OleDbDataReader reader = select.ExecuteReader();
           
            while (reader.Read())
            {
                emailList.Add(reader["email"].ToString());
            }
            conn.Close();
            return emailList;
        }

        public string getPasswordForAnEmail(string email)
        {
            OleDbCommand select = new OleDbCommand("Select password from Users where email = @email", conn);
            conn.Open();
            select.Parameters.AddWithValue("@email", email);
            OleDbDataReader reader = select.ExecuteReader();
            reader.Read();
           
            string element = reader["password"].ToString();
            conn.Close();
            return element;

        }


        public void addUser(User user)
        {
          
            OleDbCommand insert = new OleDbCommand("INSERT INTO Users (userId,name,surname,email,[password],travelsId)" +
                                                   "VALUES (@userId,@name,@surname,@email,@password,@travelsId)", conn);
            conn.Open();

            insert.Parameters.AddWithValue("@userId", user.Id);
            insert.Parameters.AddWithValue("@name", user.Name);
            insert.Parameters.AddWithValue("@surname", user.Surname);
            insert.Parameters.AddWithValue("@email", user.Email);
            insert.Parameters.AddWithValue("@password", user.Password);
            insert.Parameters.AddWithValue("@travelsId", user.TravelsId);

            insert.ExecuteNonQuery();
            conn.Close();
        }

        public User GetUser(string email)
        {
            User user = null;
            OleDbCommand select = new OleDbCommand("Select * from Users where email = @email", conn);
            conn.Open();
            select.Parameters.AddWithValue("@email", email);
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
               user = User.getInitial(reader["userId"].ToString(), reader["name"].ToString(), reader["surname"].ToString(), reader["email"].ToString(),
                                        reader["password"].ToString(), reader["travelsId"].ToString());
            }
            conn.Close();
            return user;
        }

        
        

    }
}

