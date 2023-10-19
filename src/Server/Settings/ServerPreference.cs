using System.Linq;
using RenterManager.Shared.Constants.Localization;
using RenterManager.Shared.Settings;

namespace RenterManager.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "pt-BR";
    }
}