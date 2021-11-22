using System.Threading.Tasks;
using ABP.DY.Configuration.Dto;

namespace ABP.DY.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
