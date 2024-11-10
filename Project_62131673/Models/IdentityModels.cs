using System.Data.Entity;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Services.Description;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Project_62131673.Models.EF_62131673;

namespace Project_62131673.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<ThongKe_62131673> ThongKes { get; set; }
        public DbSet<Category_62131673> Categories { get; set; }
        public DbSet<Adv_62131673> Advs { get; set; }
        public DbSet<Posts_62131673> Posts { get; set; }
        public DbSet<News_62131673> News { get; set; }
        public DbSet<SystemSetting_62131673> SystemSettings { get; set; }
        public DbSet<ProductCategory_62131673> ProductCategories { get; set; }
        public DbSet<Product_62131673> Products { get; set; }
        public DbSet<ProductImage_62131673> ProductImages { get; set; }
        public DbSet<Contact_62131673> Contacts { get; set; }
        public DbSet<Order_62131673> Orders { get; set; }
        public DbSet<OrderDetail_62131673> OrderDetails { get; set; }
        public DbSet<Subscribe_62131673> Subscribes { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}