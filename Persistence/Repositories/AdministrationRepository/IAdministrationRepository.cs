using Domain.Entities;

namespace Persistence.Repositories.AdministrationRepository
{
    public interface IAdministrationRepository
    {
        Task<List<Administration>> GetAdministrations();
        Task<Administration> GetAdministrationById(Guid id);
        Task<List<Administration>> AddAdministration(Administration administration);
        Task<List<Administration>> UpdateAdministration(Guid id, Administration request);
        Task<List<Administration>> DeleteAdministration(Guid id);
    }
}