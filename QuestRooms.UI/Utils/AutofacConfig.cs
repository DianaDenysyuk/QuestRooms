using Autofac;
using Autofac.Integration.Mvc;
using DataAccessLayer.Repositories;
using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.BLL.Services.Implementation;
using QuestRooms.DAL;
using QuestRooms.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Utils
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();



            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);



            // регистрируем споставление типов
            builder.RegisterType<CitiesService>().As<ICitiesService>();
            builder.RegisterType<GenericRepository<City>>().As<IGenericRepository<City>>();
            builder.RegisterType<RoomsContext>().As<DbContext>();
            builder.RegisterType<RoomsContext>().AsSelf();



            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();



            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}