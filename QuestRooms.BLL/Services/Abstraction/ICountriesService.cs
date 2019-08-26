using QuestRooms.BLL.DTOmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.Abstraction
{
    public interface ICountriesService
    {
        ICollection<CountryDTO> GetCountries();
    }
}
