using CourseWork;
using System.Data.Entity;

namespace AvtoShopServiceImplementDataBase
{
    public class CarDBContext : DbContext
    {
        public CarDBContext() : base("Database")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
    }
}
