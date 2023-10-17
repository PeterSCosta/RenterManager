
using RenterManager.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace RenterManager.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}