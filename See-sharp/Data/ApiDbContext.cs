using Microsoft.EntityFrameworkCore;
using See_sharp.Models;

namespace See_sharp.Data;

public class ApiDbContext: DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }

    public DbSet<Article> Articles { get; set; }

}
