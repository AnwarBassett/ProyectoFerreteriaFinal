using FerreteriaWEB.Modelos;

namespace FerreteriaWEB.Repository.IRepository
{
    public interface ISalidasRepository : IRepository<Salidas>
    {
        Task<Salidas> Update(Salidas entity);
    }
}
