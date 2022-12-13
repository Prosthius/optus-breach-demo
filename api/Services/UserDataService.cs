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
        return _context.UserDatas.AsNoTracking().ToList();
    }

    public UserData? GetById(int id)
    {
        return _context.UserDatas
            .AsNoTracking()
            .SingleOrDefault(userData => userData.Id == id);
    }
}