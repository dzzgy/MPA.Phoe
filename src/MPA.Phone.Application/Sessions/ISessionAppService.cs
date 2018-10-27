using System.Threading.Tasks;
using Abp.Application.Services;
using MPA.Phone.Sessions.Dto;

namespace MPA.Phone.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
