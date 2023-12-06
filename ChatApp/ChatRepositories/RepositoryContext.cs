using ChatEntities;
using Microsoft.EntityFrameworkCore;

namespace ChatRepositories;

public class RepositoryContext : DbContext  
{
    public DbSet<Chats> Chats { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Chats>().HasData(
            new Chats(){Id=1,UserName="MOHAMMED",Message="Hello Wolrd!!",SendDate=DateTime.Now},
            new Chats(){Id=2,UserName="Manger",Message="Hi Wolrd!!",SendDate=DateTime.Now},
            new Chats(){Id=3,UserName="Fakid",Message="Hello There!!",SendDate=DateTime.Now}
        );
    }
}
