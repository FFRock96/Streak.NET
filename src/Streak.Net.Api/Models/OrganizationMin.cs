using Newtonsoft.Json;

namespace Streak.Net.Api.Models
{
    public class OrganizationMin : BaseObject
    {
        [JsonProperty(PropertyName = "isStarred")]
        public bool IsStarred { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
}
