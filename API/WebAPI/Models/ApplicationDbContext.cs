using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WebAPI.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Inspection> Inspection { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Inspector> Inspector { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}