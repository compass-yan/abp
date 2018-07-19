using System.Threading.Tasks;
using Abp.Application.Services;
using yzn.Sessions.Dto;

namespace yzn.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
