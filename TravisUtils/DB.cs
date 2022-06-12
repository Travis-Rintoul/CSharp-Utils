using System.Data;
using TravisUtils;

namespace TravisUtils
{
    public class DB
    {
        private string ConnectionString
        {
            get { return Utils.ConectionString;  }
            set { Utils.ConectionString = value; }
        }
        
        public static object Test() 
        {
            return null;
        }

        public static object Test2()
        {
            return null;
        }

        public static DataTable ExecuteReader(string SQL, string[] Keys, object[] Values)
        {
            
            return new DataTable();
        }
    }
}
