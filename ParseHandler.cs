using System.Text;
using System.Web.Services.Description;

namespace geztoz_asp
{
    public class ParseHandler
    {
        ParseHandler(){}

        public static string parseStringToUtf8(string stringValue)
        {
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            Encoding utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(stringValue);
            byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
            string msg = iso.GetString(isoBytes);
            return msg;
        }
    }
}