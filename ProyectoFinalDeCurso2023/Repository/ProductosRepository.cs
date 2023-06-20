using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Repository
{
    public class ProductosRepository : Repository<Productos>, IProductosRepository
    {
        private readonly FerreteriaContext _db;

        public ProductosRepository(FerreteriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Productos> Update(Productos entity)
        {
            _db.Productos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
