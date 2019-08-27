using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Configuration
{
    public class DbInitializer : DropCreateDatabaseAlways<RoomsContext>
    {
        private List<string> SqlFiles = new List<string>()
        {
            "/bin/MockData/Cities.sql",
            "/bin/MockData/Streets.sql",
            "/bin/MockData/Countries.sql",
            "/bin/MockData/Addresses.sql",
            "/bin/MockData/Companies.sql",
            "/bin/MockData/Rooms.sql"
        };

        protected override void Seed(RoomsContext context)
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory;
            foreach(var f in SqlFiles)
            {
                context.Database.ExecuteSqlCommand(ReadSql(path + f));
            }
        }

        private string ReadSql(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }

    }
}
