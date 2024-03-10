using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using eManager.Configuration.Dto;

namespace eManager.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : eManagerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
