using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using yzn.Roles.Dto;
using yzn.Users.Dto;

namespace yzn.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
