using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly FerreteriaContext _db;

        public ClienteRepository(FerreteriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Cliente> Update(Cliente entity)
        {
            _db.clientes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
