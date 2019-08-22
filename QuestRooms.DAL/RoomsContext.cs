namespace QuestRooms.DAL
{
    using QuestRooms.DAL.Configuration;
    using QuestRooms.DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RoomsContext : DbContext
    {
        // Your context has been configured to use a 'RoomsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuestRooms.DAL.RoomsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RoomsContext' 
        // connection string in the application configuration file.
        public RoomsContext()
            : base("name=RoomsContext")
        {
            //Database.SetInitializer(new DbInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}