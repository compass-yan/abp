using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using yzn.Roles.Dto;

namespace yzn.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
