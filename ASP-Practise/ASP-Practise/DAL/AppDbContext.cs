using ASP_Practise.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Practise.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeLeft> NoticeLefts { get; set; }
        public DbSet<NoticeRight> NoticeRights { get; set; }

    }
}
