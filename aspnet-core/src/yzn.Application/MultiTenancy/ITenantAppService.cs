using Abp.Application.Services;
using Abp.Application.Services.Dto;
using yzn.MultiTenancy.Dto;

namespace yzn.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
