using Api.Models;
using Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Services;

public class ApiService
{
    private readonly ApiContext _context;

    public ApiService(ApiContext context)
    {
        _context = context;
    }

    public IEnumerable<UserData> GetAll()
    {
        return _context.users.AsNoTracking().ToList();
    }

    public UserData? GetById(int id)
    {
        return _context.users
            .AsNoTracking()
            .SingleOrDefault(users => users.Id == id);
    }

    public UserData Create(UserData newUser)
    {
        _context.users.Add(newUser);
        _context.SaveChanges();

        return newUser;
    }
}