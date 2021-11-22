using Abp.Application.Services;
using ABP.DY.MultiTenancy.Dto;

namespace ABP.DY.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

