using System.Threading.Tasks;
using yzn.Configuration.Dto;

namespace yzn.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
