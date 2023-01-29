using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories.AdministrationRepository
{
    public class AdministrationRepository : IAdministrationRepository
    {
        private readonly DataContext _context;
        public AdministrationRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Administration>> AddAdministration(Administration administration)
        {
            _context.Administration.Add(administration);
            await _context.SaveChangesAsync();
            return await _context.Administration.ToListAsync();
        }

        public async Task<List<Administration>> DeleteAdministration(Guid id)
        {
            var administration = await _context.Administration.FindAsync(id);
            if (administration is null)
            {
                return null; //make a custom API response class for this
            }
            _context.Administration.Remove(administration);
            await _context.SaveChangesAsync();
            return await _context.Administration.ToListAsync();
        }

        public async Task<Administration> GetAdministrationById(Guid id)
        {
            var administration = await _context.Administration.FindAsync(id);
            if (administration is null)
            {
                return null;
            }
            return administration;
        }

        public async Task<List<Administration>> GetAdministrations()
        {
            var administrations = await _context.Administration.ToListAsync();
            return administrations;
        }

        public async Task<List<Administration>> UpdateAdministration(Guid id, Administration request)
        {
            var administration = await _context.Administration.FindAsync(id);
            if (administration is null)
            {
                return null;
            }
            administration.Leader = request.Leader;
            await _context.SaveChangesAsync();
            return await _context.Administration.ToListAsync();
        }
    }
}