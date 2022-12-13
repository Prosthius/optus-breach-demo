using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options){}

    public DbSet<UserData> users => Set<UserData>();

    // public DbSet<UserData>? userData { get; set; }
}
