using System.Threading.Tasks;
using eManager.Configuration.Dto;

namespace eManager.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
