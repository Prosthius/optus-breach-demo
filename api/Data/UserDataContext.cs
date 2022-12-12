using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options){}

    public DbSet<UserData> UserDatas => Set<UserData>();
}