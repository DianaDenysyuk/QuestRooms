using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.DTOmodels
{
    public class ImageDTO
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public RoomDTO Room { get; set; }
    }
}
