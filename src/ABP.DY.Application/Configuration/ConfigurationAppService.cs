using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP.DY.Configuration.Dto;

namespace ABP.DY.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DYAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
