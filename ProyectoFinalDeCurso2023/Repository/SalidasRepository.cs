using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Repository
{
    public class SalidasRepository : Repository<Salidas>, ISalidasRepository
    {
        private readonly FerreteriaContext _db;

        public SalidasRepository(FerreteriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Salidas> Update(Salidas entity)
        {
            _db.salidas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
