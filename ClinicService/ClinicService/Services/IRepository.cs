using ClinicService.Models;

namespace ClinicService.Services
{
    public interface IRepository<T, TId>
    {
        int Create(T item);
        int Update(T item);

        int Delete(TId id);

        T GetById(TId id);
        List<T> GetAll();
    }
}
