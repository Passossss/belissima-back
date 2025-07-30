using belissima_back.Models;
using Microsoft.EntityFrameworkCore;

namespace belissima_back.Services;

public class RevendedoraService : IRevendedoraService
{
    private readonly AppDbContext _context;

    public RevendedoraService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Revendedora>> GetAllAsync()
    {
        return await _context.Revendedoras.ToListAsync();
    }

    public async Task<Revendedora?> GetByIdAsync(int id)
    {
        return await _context.Revendedoras.FindAsync(id);
    }


}
