using System;
using System.Collections.Generic;

namespace geztoz_asp
{
    public class Travel
    {

        private string travelId;
        private string driverId;
        private string driverName;
        private string driverSurname;
        private string passengersId = "";
        private int totalSeat;
        private int availableSeat;
        private string fromDestination;
        private string toDestination;
        private DateTime travelDate;
        private string travelTime;
        
        private static Travel travel;

        public string TravelId
        {
            get => this.travelId;
            set => this.travelId = value;
        }
        public string DriverId
        {
            get => driverId;
            set => driverId = value;
        }
        public string DriverName
        {
            get => this.driverName;
            set => this.driverName = value;
        }
        public string DriverSurname
        {
            get => this.driverSurname;
            set => this.driverSurname = value;
        }
        public string PassengersId
        {
            get => this.passengersId;
            set => this.passengersId = value;
        }
        public int TotalSeat
        {
            get => this.totalSeat;
            set => this.totalSeat = value;
        }
        public int AvailableSeat
        {
            get => this.availableSeat;
            set => this.availableSeat = value;
        }
        public string FromDestination
        {
            get => this.fromDestination;
            set => this.fromDestination = value;
        }
        public string ToDestination
        {
            get => this.toDestination;
            set => this.toDestination = value;
        }
        public DateTime TravelDate
        {
            get => this.travelDate;
            set => this.travelDate = value;
        }

        public string TravelTime
        {
            get => this.travelTime;
            set => this.travelTime = value;
        }

        public void setNull()
        {
            travel = null;
        }
        
        Travel(string travelId, string driverId,string driverName, string driverSurname,string passengersId,int totalSeat,int availableSeat,string fromDestination,string toDestination,DateTime travelDate, string travelTime )
        {
            this.travelId = travelId;
            this.driverId = driverId;
            this.driverName = driverName;
            this.driverSurname = driverSurname;
            this.passengersId = passengersId;
            this.totalSeat = totalSeat;
            this.availableSeat = availableSeat;
            this.fromDestination = fromDestination;
            this.toDestination = toDestination;
            this.travelDate = travelDate;
            this.travelTime = travelTime;
        }

        public static Travel getInitial(string travelId = "", string driverId= "", string driverName = "", string driverSurname = "", string passengersId = "", int totalSeat = 0, int availableSeat = 0, string fromDestination = "", string toDestination = "", DateTime travelDate = new DateTime(), string travelTime = "")
        {
            if (travel == null)
            {
                travel = new Travel(travelId, driverId,driverName,driverSurname,passengersId,totalSeat,availableSeat,fromDestination,toDestination,travelDate,travelTime);
                return travel;
            }
            else
            {
                return travel;
            }
        }

    }

    public class TravelHandler
    {

        private DatabaseHandler dh = DatabaseHandler.getInitial();
        static TravelHandler travelHandler;
        private bool isValidSeat = false;
        private bool isEmpty= false;
        private bool isValidTravelDate = false;
        private TravelHandler() { }

        public void setNull()
        {
            travelHandler = null;
        }

        public static TravelHandler getInitial()
        {
            if (travelHandler == null)
            {
                travelHandler = new TravelHandler();
                return travelHandler;
            }
            else
            {
                return travelHandler;
            }
        }
        
        
        public void registerTravel(string driverId, string driverName,string driverSurname,int totalSeat, int availableSeat, string fromDestination, string toDestination, DateTime travelDate, string travelTime)
        {
            isValidSeat = Validation.validateSeat(totalSeat, availableSeat);
            isEmpty = Validation.validateTravelRegisterInputsEmpty(driverName, driverSurname, fromDestination, toDestination);
            isValidTravelDate = Validation.validateTravelDate(travelDate);

            if (isValidSeat && isEmpty && isValidTravelDate)
            {
                Travel travel = Travel.getInitial(generateTravelId(),driverId,driverName,driverSurname,"",totalSeat,availableSeat,fromDestination,toDestination,travelDate, travelTime);
                dh.addTravel(travel);
                travel.setNull();
                isEmpty = false;
                isValidTravelDate = false;
                isValidSeat = false;
            }
        }

        private string generateTravelId()
        {
            bool isValid = false;
            string id = "travel-";
            Random random = new Random();
            id += random.Next(1, 1000000).ToString();
            isValid = Validation.validateTravelId(id);
            if (isValid)
            {
                return id;
            }
            else
            {
                return generateTravelId();
            }
        }

        public List<Travel> getTravels(string from, string to, int wantedSeat, DateTime travelDate)
        {
            isEmpty = Validation.validateTravelSearchInputsEmpty(from, to, wantedSeat);
            isValidTravelDate = Validation.validateTravelDate(travelDate);
            isValidSeat = Validation.validateWantedSeat(wantedSeat);

            if (isEmpty && isValidTravelDate && isValidSeat)
            {
                return dh.getFilteredTravels(from, to, wantedSeat, travelDate);
            }
            else
            {
                return new List<Travel>(); 
            }
        }
    }
}