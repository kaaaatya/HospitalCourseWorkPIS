using System.Data.Entity;

namespace HospitalModel
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base("HospitalDbContext")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<PatientCard> PatientCards { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services{ set; get; }
        public DbSet<SicknessHistory> SicknessHistories { set; get; }
        public DbSet<Treatment> Treatments { set; get; }
        public DbSet<Worker> Workers { set; get; }
    }
}
