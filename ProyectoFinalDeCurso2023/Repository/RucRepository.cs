using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Repository
{
    public class RucRepository : Repository<Ruc>, IRucRepository
    {
        private readonly FerreteriaContext _db;

        public RucRepository(FerreteriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Ruc> Update(Ruc entity)
        {
            _db.rucs.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
