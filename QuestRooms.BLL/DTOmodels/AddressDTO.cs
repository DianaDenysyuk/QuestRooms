using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.DTOmodels
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public int HouseNumber { get; set; }
        public CityDTO City { get; set; }
        public CountryDTO Country { get; set; }
        public StreetDTO Street { get; set; }
    }
}
