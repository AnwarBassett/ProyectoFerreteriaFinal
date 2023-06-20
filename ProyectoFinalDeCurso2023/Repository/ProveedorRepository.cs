using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Repository
{
    public class ProveedorRepository : Repository<Proveedor>, IProveedorRepository
    {
        private readonly FerreteriaContext _db;

        public ProveedorRepository(FerreteriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Proveedor> Update(Proveedor entity)
        {
            _db.proveedores.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
