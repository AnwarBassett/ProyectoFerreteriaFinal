using FerreteriaWEB.Modelos;

namespace FerreteriaWEB.Repository.IRepository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente> Update(Cliente entity);
    }
}
