using System;

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

        Travel(string travelId, string driverId,string driverName, string driverSurname,string passengersId,int totalSeat,int availableSeat,string fromDestination,string toDestination,DateTime travelDate )
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

        }

        public static Travel getInitial(string travelId = "", string driverId= "", string driverName = "", string driverSurname = "", string passengersId = "", int totalSeat = 0, int availableSeat = 0, string fromDestination = "", string toDestination = "", DateTime travelDate = new DateTime())
        {
            if (travel == null)
            {
                travel = new Travel(travelId, driverId,driverName,driverSurname,passengersId,totalSeat,availableSeat,fromDestination,toDestination,travelDate);
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
        private bool isValidRegister= false;
        private bool isValidTraveDate = false;
        private TravelHandler() { }

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


        public void setNull()
        {
            travelHandler = null;
        }

        public void registerTravel(string driverId, string driverName,string driverSurname,int totalSeat, int availableSeat, string fromDestination, string toDestination, DateTime travelDate)
        {
            isValidSeat = Validation.validateSeat(totalSeat, availableSeat);
            isValidRegister = Validation.validateRegisterTravelEmpty(driverName, driverSurname, fromDestination, toDestination);
            isValidTraveDate = Validation.validateTravelDate(travelDate);

            if (isValidSeat && isValidRegister && isValidTraveDate)
            {
                Travel travel = Travel.getInitial(generateTravelId(),driverId,driverName,driverSurname,"",totalSeat,availableSeat,fromDestination,toDestination,travelDate);
                dh.addTravel(travel);
            }
        }

        private string generateTravelId()
        {
            bool isValid = false;
            string id = "travel-";
            Random random = new Random();
            int randomNumber = random.Next(1, 1000000);
            id += randomNumber.ToString();
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
    }
}