using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.DTOmodels
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public TimeSpan AllTime { get; set; }
        public int Rating { get; set; }
        public int LvlFear { get; set; }
        public int LvlDifficulty { get; set; }
        public string Logo { get; set; }
        public AddressDTO Address { get; set; }
        public CompanyDTO Company { get; set; }
        public ICollection<ImageDTO> Images { get; set; }
    }
}
