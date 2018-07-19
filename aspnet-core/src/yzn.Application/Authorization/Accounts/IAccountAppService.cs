using System.Threading.Tasks;
using Abp.Application.Services;
using yzn.Authorization.Accounts.Dto;

namespace yzn.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
