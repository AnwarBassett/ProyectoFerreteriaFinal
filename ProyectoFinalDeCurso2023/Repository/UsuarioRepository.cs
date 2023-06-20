using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly FerreteriaContext _db;

        public UsuarioRepository(FerreteriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Usuario> Update(Usuario entity)
        {
            _db.usuarios.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
