using AutoMapper;
using DataAccessLayer.Repositories;
using QuestRooms.BLL.DTOmodels;
using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Services.Implementation
{
    public class CitiesService : ICitiesService
    {
        private readonly IMapper mapper;
        private readonly IGenericRepository<City> cityRepos;
        public CitiesService(IGenericRepository<City> _cityRepos, IMapper _mapper)
        {
            cityRepos = _cityRepos;
            mapper = _mapper;
        }
        public ICollection<CityDTO> GetCities()
        {
            var cities = cityRepos.GetAll().ToList();
            //List<CityDTO> res = new List<CityDTO>();
            //foreach (var c in cities)
            //{
            //    res.Add(new CityDTO { Id = c.Id, Name = c.Name });
            //}
            return mapper.Map<List<City>, ICollection<CityDTO>>(cities);
        }
    }
}
