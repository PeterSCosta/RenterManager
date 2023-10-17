using System.Text.Json;
using RenterManager.Application.Interfaces.Serialization.Options;

namespace RenterManager.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}