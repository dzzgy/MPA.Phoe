using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPA.Phone.MultiTenancy.Dto;

namespace MPA.Phone.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
