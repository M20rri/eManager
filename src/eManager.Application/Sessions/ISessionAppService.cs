using System.Threading.Tasks;
using Abp.Application.Services;
using eManager.Sessions.Dto;

namespace eManager.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
