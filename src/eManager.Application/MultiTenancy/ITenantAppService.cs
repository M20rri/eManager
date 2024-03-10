using Abp.Application.Services;
using eManager.MultiTenancy.Dto;

namespace eManager.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

