using System.Threading.Tasks;
using Abp.Application.Services;
using MPA.Phone.Authorization.Accounts.Dto;

namespace MPA.Phone.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
