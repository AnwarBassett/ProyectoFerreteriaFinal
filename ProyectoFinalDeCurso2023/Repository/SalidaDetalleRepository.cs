using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Repository
{
    public class SalidaDetalleRepository : Repository<SalidaDetalle>, ISalidaDetalleRepository
    {
        private readonly FerreteriaContext _db;

        public SalidaDetalleRepository(FerreteriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<SalidaDetalle> Update(SalidaDetalle entity)
        {
            _db.salidaDetalles.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
