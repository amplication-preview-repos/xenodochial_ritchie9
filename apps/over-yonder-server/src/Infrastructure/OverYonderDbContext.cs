using Microsoft.EntityFrameworkCore;

namespace OverYonder.Infrastructure;

public class OverYonderDbContext : DbContext
{
    public OverYonderDbContext(DbContextOptions<OverYonderDbContext> options)
        : base(options) { }
}
