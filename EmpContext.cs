
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo_WebAPI_MVC_CORE.Models;
namespace Demo_WebAPI_MVC_CORE
{
    public class EmpContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\PUSHPALATHA.BOYA\SOURCE\REPOS\DEMO_WEBAPI_MVC_CORE\DEMO_WEBAPPLICATION\APP_DATA\MYDATABASE.MDF;Integrated Security=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

