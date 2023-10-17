using RenterManager.Shared.Settings;
using System.Threading.Tasks;
using RenterManager.Shared.Wrapper;

namespace RenterManager.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}