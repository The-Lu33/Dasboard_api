using Dashboard_APi.Models;
using Microsoft.EntityFrameworkCore;
namespace Dashboard_APi.Data
{
    public class DashboardDB : DBContext
    {
        public DashboardDBt(DbContextOptions<officeDb> options);
        public DbSet<Users> User => set<Users>();
    }
}