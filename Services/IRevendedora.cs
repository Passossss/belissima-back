using belissima_back.Models;

namespace belissima_back.Services;

public interface IRevendedoraService
{
    Task<IEnumerable<Revendedora>> GetAllAsync();
    Task<Revendedora?> GetByIdAsync(int id);
}