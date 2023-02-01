using Domain.Entities;

namespace Application.Services.RequestService
{
    public interface IRequestService
    {
        Task<List<Request>> GetAllRequests();
        Task<Request> GetRequestById(Guid id);
        Task<List<Request>> AddRequest(Request request);
        Task<List<Request>> UpdateRequest(Guid id, Request request);
        Task<List<Request>> DeleteRequest(Guid id);
    }
}