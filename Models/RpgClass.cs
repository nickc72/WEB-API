using System.Text.Json.Serialization;

namespace WEB_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Mage,

        Knight,

        Cleric

    }
           
    
}