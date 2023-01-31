using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services.RequestService
{
    public class RequestService : IRequestService
    {
        private readonly DataContext _context;
        public RequestService(DataContext context)
        {
            _context = context;
        }
        
        public async Task<List<Request>> GetRequestsAsync()
        {
            var results = await _context.Request.ToListAsync();
            return results;
        }

        public async Task<Request> GetRequestById(Guid id)
        {
            var request = await _context.Request.FindAsync(id);
            if(request is null)
            {
                return null;
            }
            return request;
        }

        public async Task<List<Request>> AddRequest(Request request)
        {
            _context.Request.Add(request);
            await _context.SaveChangesAsync();
            return await _context.Request.ToListAsync();
        }

        public async Task<List<Request>> UpdateRequest(Guid id, Request request)
        {
            var result = await _context.Request.FindAsync(id);
            if(result is null)
            {
                return null;
            }

            result.Description = request.Description;
            result.Administration = result.Administration;
            result.User = request.User;

            await _context.SaveChangesAsync();
            return await _context.Request.ToListAsync();
        }

        public async Task<List<Request>> DeleteRequest(Guid id)
        {
            var request = await _context.Request.FindAsync(id);
            if(request is null)
            {
                return null;
            }
            
            _context.Request.Remove(request);
            await _context.SaveChangesAsync();
            return await _context.Request.ToListAsync();
        }
    }
}