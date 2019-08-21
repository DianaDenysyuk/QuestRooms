using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Configuration
{
    public class DbInitializer : DropCreateDatabaseAlways<RoomsContext>
    {
        protected override void Seed(RoomsContext context)
        {
            
        }
    }
}
