using AutoMapper;
using QuestRooms.BLL.DTOmodels;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<City, CityDTO>();
            CreateMap<Country, CountryDTO>();
            CreateMap<Street, StreetDTO>();
            CreateMap<Address, AddressDTO>();
            CreateMap<Company, CompanyDTO>();
            CreateMap<Image, ImageDTO>();
            CreateMap<Room, RoomDTO>();

        }
    }
}
