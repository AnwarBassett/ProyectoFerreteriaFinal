using FerreteriaWEB.Modelos;

namespace FerreteriaWEB.Repository.IRepository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> Update(Usuario entity);
    }
}
