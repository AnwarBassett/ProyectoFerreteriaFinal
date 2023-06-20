using FerreteriaWEB.Modelos;

namespace FerreteriaWEB.Repository.IRepository
{
    public interface IProveedorRepository : IRepository<Proveedor>
    {
        Task<Proveedor> Update(Proveedor entity);
    }
}
