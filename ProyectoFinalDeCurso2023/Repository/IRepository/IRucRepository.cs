using FerreteriaWEB.Modelos;

namespace FerreteriaWEB.Repository.IRepository
{
    public interface IRucRepository : IRepository<Ruc>
    {
        Task<Ruc> Update(Ruc entity);
    }
}
