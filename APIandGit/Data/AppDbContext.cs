using Microsoft.EntityFrameworkCore;

namespace APIandGit.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {
            
        }
    }
}
