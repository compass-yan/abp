using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using yzn.Configuration.Dto;

namespace yzn.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : yznAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
