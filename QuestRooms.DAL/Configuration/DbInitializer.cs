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
            "MockData/Cities.sql"
        };

        protected override void Seed(RoomsContext context)
        {
            foreach(var f in SqlFiles)
            {
                context.Database.ExecuteSqlCommand(ReadSql(f));
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
