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
    public class RoomsService : IRoomsService
    {
        private readonly IMapper mapper;
        private readonly IGenericRepository<Room> roomRepos;
        public RoomsService(IGenericRepository<Room> _roomRepos, IMapper _mapper)
        {
            roomRepos = _roomRepos;
            mapper = _mapper;
        }
        public ICollection<RoomDTO> GetRooms()
        {
            var rooms = roomRepos.GetAll().ToList();
            return mapper.Map<List<Room>, ICollection<RoomDTO>>(rooms);
        }
    }
}
