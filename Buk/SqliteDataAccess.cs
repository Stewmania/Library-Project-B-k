using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buk
{
   public class SqliteDataAccess
    {
        public static List<Buk_Main_Interface> LoadLibray()
        { 
        using (System.Data.IDbConnection cnn = new System.Data.SQLite.SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Buk_Main_Interface>("select * from Library", new DynamicParameters());
                return output.ToList();
            }

        
        }

        public static void SaveLibrary(Buk_Main_Interface Library)
        {
            using (System.Data.IDbConnection cnn = new System.Data.SQLite.SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Library (Title, Author, Description, Cover, PublishD, Rating) values (@Title, @Author, @Description, @Cover, @PublishD, @Rating)", Library);
            }


        }

        private static string LoadConnectionString(string id = "Default")
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
