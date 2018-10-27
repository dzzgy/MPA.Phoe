using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MPA.Phone.Configuration.Dto;

namespace MPA.Phone.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhoneAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
