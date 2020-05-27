using System.Web;

namespace geztoz_asp
{
    public class LogOut
    {
        private DatabaseHandler dh;
        private UserHandler userHandler;
        private User user;
         public LogOut()
         {
             dh = DatabaseHandler.getInitial();
             userHandler = UserHandler.getInitial();
             user = User.getInitial();
             dh = null;
             userHandler = null;
             user = null;
         }


        
    }
}