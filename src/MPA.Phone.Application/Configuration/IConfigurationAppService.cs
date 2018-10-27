using System.Threading.Tasks;
using MPA.Phone.Configuration.Dto;

namespace MPA.Phone.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
