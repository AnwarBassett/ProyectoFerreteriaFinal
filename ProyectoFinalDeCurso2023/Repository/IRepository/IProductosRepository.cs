using FerreteriaWEB.Modelos;

namespace FerreteriaWEB.Repository.IRepository
{
    public interface IProductosRepository : IRepository<Productos>
    {
        Task<Productos> Update(Productos entity);
    }
}
