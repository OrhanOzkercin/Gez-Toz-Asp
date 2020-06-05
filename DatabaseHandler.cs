using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Net.Configuration;

namespace geztoz_asp
{

    public class DatabaseHandler
    {
        private static OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\egil_\Desktop\proje_asp\geztoz_asp\geztoz_asp\App_Data\main.mdb;Persist Security Info=True");
        private static DatabaseHandler dh;
        private DatabaseHandler() { }

        public void setNull()
        {
            dh = null;
        }

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

        //This part is all about user database operations.

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

        public User getUser(string email)
        {
            User user = null;
            OleDbCommand select = new OleDbCommand("Select * from Users where email = @email", conn);
            conn.Open();
            select.Parameters.AddWithValue("@email", email);
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                user = User.getInitial(reader["userId"].ToString(), reader["name"].ToString(), reader["surname"].ToString(), reader["email"].ToString(),
                                         reader["password"].ToString());
            }
            conn.Close();
            return user;
        }

        public bool updateUser(User user)
        {

            try
            {
                OleDbCommand update = new OleDbCommand("UPDATE Users SET [name] = @name, [surname] = @surname, [email] = @email, [password] = @password WHERE [userId] = @userId", conn);

                conn.Open();
                update.Parameters.AddWithValue("@name", user.Name);
                update.Parameters.AddWithValue("@surname", user.Surname);
                update.Parameters.AddWithValue("@email", user.Email);
                update.Parameters.AddWithValue("@password", user.Password);
                update.Parameters.AddWithValue("@userId", user.Id);

                update.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        //This part is all about travel database operations. 

        public void addTravel(Travel travel)
        {
            OleDbCommand insert = new OleDbCommand("INSERT INTO Travels ( travelId, driverId, driverName, driverSurname, passengersId, totalSeat, availableSeat, [from], [to], travelDate, travelTime )" +
                                                   "VALUES (@travelId,@driverId,@driverName,@driverSurname,@passengersId,@totalSeat,@availableSeat,@from,@to,@travelDate,@travelTime)", conn);
            conn.Open();

            insert.Parameters.AddWithValue("@travelId", travel.TravelId);
            insert.Parameters.AddWithValue("@driverId", travel.DriverId);
            insert.Parameters.AddWithValue("@driverName", travel.DriverName);
            insert.Parameters.AddWithValue("@driverSurname", travel.DriverSurname);
            insert.Parameters.AddWithValue("@passengersId", travel.PassengersId);
            insert.Parameters.AddWithValue("@totalSeat", travel.TotalSeat);
            insert.Parameters.AddWithValue("@availableSeat", travel.AvailableSeat);
            insert.Parameters.AddWithValue("@from", travel.FromDestination);
            insert.Parameters.AddWithValue("@to", travel.ToDestination);
            insert.Parameters.AddWithValue("@travelDate", travel.TravelDate);
            insert.Parameters.AddWithValue("@travelTime", travel.TravelTime);

            insert.ExecuteNonQuery();
            conn.Close();
        }

        public List<string> getAllTravelIds()
        {
            List<string> travelIdList = new List<string>();
            OleDbCommand select = new OleDbCommand("Select travelId from Travels", conn);
            conn.Open();

            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                travelIdList.Add(reader["travelId"].ToString());
            }

            conn.Close();
            return travelIdList;
        }

        public List<Travel> getFilteredTravels(string from, string to, int availableSeat, DateTime travelDate)
        {
            List<Travel> filteredTravels = new List<Travel>();
            OleDbCommand select = new OleDbCommand("Select * from Travels where from = @from and to=@to and availableSeat >= @availableSeat and travelDate = @travelDate ", conn);
            conn.Open();
            select.Parameters.AddWithValue("@from", from);
            select.Parameters.AddWithValue("@to", to);
            select.Parameters.AddWithValue("@availableSeat", availableSeat);
            select.Parameters.AddWithValue("@travelDate", travelDate);
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                Travel travel = Travel.getInitial(reader["travelId"].ToString(), reader["driverId"].ToString(), reader["driverName"].ToString(), reader["driverSurname"].ToString()
                    , reader["passengersId"].ToString(), int.Parse(reader["totalSeat"].ToString()), int.Parse(reader["availableSeat"].ToString()), from, to, travelDate, reader["travelTime"].ToString());
                travel.setNull();
                filteredTravels.Add(travel);
            }
            conn.Close();
            return filteredTravels;
        }

        public Travel getTravelByTravelId(string travelId)
        {
            Travel travel = null;
            OleDbCommand select = new OleDbCommand("Select * from Travels where travelId = @travelId ", conn);
            conn.Open();
            select.Parameters.AddWithValue("@travelId", travelId);
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                travel = Travel.getInitial(reader["travelId"].ToString(), reader["driverId"].ToString(), reader["driverName"].ToString(), reader["driverSurname"].ToString()
                   , reader["passengersId"].ToString(), int.Parse(reader["totalSeat"].ToString()), int.Parse(reader["availableSeat"].ToString()), reader["from"].ToString(), reader["to"].ToString(), DateTime.Parse(reader["travelDate"].ToString()));
                travel.setNull();
            }
            conn.Close();
            return travel;
        }

        private string getAllPassengerIdsFromCertainTravel(Travel travel)
        {
            string passengerId = "";
            OleDbCommand select = new OleDbCommand("Select * from Travels where travelId = @travelId", conn);
            conn.Open();
            select.Parameters.AddWithValue("@travelId", travel.TravelId);
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                passengerId = reader["passengersId"].ToString();
            }

            conn.Close();
            return passengerId;
        }

        private int getTotalSeatFromCertainTravel(string travelId)
        {
            int availableSeat = 0;
            OleDbCommand select = new OleDbCommand("Select totalSeat from Travels where travelId = @travelId ", conn);
            conn.Open();
            select.Parameters.AddWithValue("@travelId", travelId);
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                availableSeat = int.Parse(reader["totalSeat"].ToString());
            }
            conn.Close();
            return availableSeat;
        }

        private int getAvailableSeatFromCertainTravel(string travelId)
        {
            int availableSeat = 0;
            OleDbCommand select = new OleDbCommand("Select availableSeat from Travels where travelId = @travelId ", conn);
            conn.Open();
            select.Parameters.AddWithValue("@travelId", travelId);
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                availableSeat = int.Parse(reader["availableSeat"].ToString());
            }
            conn.Close();
            return availableSeat;
        }

        public bool updatePassengers(string travelId, string passengerId)
        {
            bool isValid = false;
            Travel travel = getTravelByTravelId(travelId);
            string existPassengerId = getAllPassengerIdsFromCertainTravel(getTravelByTravelId(travelId));
            isValid = Validation.validateIsPassengerAlreadySignUpForCertainTravel(existPassengerId, passengerId, travel.DriverId);
            existPassengerId = existPassengerId == "" ? (existPassengerId = passengerId) : (existPassengerId += "/" + passengerId);
            if (isValid)
            {
                try
                {
                    OleDbCommand update = new OleDbCommand("UPDATE Travels SET [passengersId] = @passengersId WHERE [travelId] = @travelId ", conn);

                    conn.Open();
                    update.Parameters.Add("@passengersId", existPassengerId);
                    update.Parameters.Add("@travelId", travelId);

                    update.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                return false;
            }

        }

        public bool updateAvailableSeat(string travelId,int signedSeat)
        {
            int availableSeat = getAvailableSeatFromCertainTravel(travelId);
            int totalSeat = getTotalSeatFromCertainTravel(travelId);
            availableSeat -= signedSeat;
            if (Validation.validateSeat(totalSeat, availableSeat))
            {
                try
                {
                    OleDbCommand update = new OleDbCommand("UPDATE Travels SET  availableSeat= @availableSeat WHERE [travelId] = @travelId ", conn);

                    conn.Open();
                    update.Parameters.Add("@availableSeat", availableSeat);
                    update.Parameters.Add("@travelId", travelId);

                    update.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

