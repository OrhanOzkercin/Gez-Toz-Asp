using System.Text;

namespace geztoz_asp
{
    public class ParseHandler
    {
        ParseHandler(){}

        public static string parseStringToUtf8(string stringValue)
        {
            Encoding.GetEncoding("iso-8859-9");
            byte[] bytes = Encoding.Default.GetBytes(stringValue);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}