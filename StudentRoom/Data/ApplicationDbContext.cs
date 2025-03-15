using Microsoft.EntityFrameworkCore;
using StudentRoom.Models;

namespace StudentRoom.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options) 
    {

        public DbSet<Users> User {  get; set; }
    }
}
