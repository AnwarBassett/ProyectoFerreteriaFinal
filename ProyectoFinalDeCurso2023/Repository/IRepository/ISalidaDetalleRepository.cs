using FerreteriaWEB.Modelos;

namespace FerreteriaWEB.Repository.IRepository
{
    public interface ISalidaDetalleRepository : IRepository<SalidaDetalle>
    {
        Task<SalidaDetalle> Update(SalidaDetalle entity);
    }
}
