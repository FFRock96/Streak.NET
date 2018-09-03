using Newtonsoft.Json;
using System.Collections.Generic;

namespace Streak.Net.Api.Models
{
    public class Contact: BaseObject
    {
        [JsonProperty(PropertyName = "teamKey")]
        public string TeamKey { get; set; }

        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        [JsonProperty(PropertyName = "familyName")]
        public string FamilyName { get; set; }

        [JsonProperty(PropertyName = "emailAddresses")]
        public List<string> EmailAddresses { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "other")]
        public string Other { get; set; }

        [JsonProperty(PropertyName = "phoneNumbers")]
        public List<string> PhoneNumbers { get; set; }

        [JsonProperty(PropertyName = "addresses")]
        public List<string> Addresses { get; set; }

        [JsonProperty(PropertyName = "twitterHandle")]
        public string TwitterHandle { get; set; }

        [JsonProperty(PropertyName = "facebookHandle")]
        public string FacebookHandle { get; set; }

        [JsonProperty(PropertyName = "linkedinHandle")]
        public string LinkedinHandle { get; set; }

        [JsonProperty(PropertyName = "photoURL")]
        public string PhotoURL { get; set; }

        [JsonProperty(PropertyName = "lastEnrichmentTimestamp")]
        public long LastEnrichmentTimestamp { get; set; }

        [JsonProperty(PropertyName = "lastSavedUserKey")]
        public string LastSavedUserKey { get; set; }

        [JsonProperty(PropertyName = "creatorKey")]
        public string CreatorKey { get; set; }

        [JsonProperty(PropertyName = "creationDate")]
        public long CreationDate { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "versionTimestamp")]
        public long VersionTimestamp { get; set; }

        [JsonProperty(PropertyName = "lastSavedTimestamp")]
        public long LastSavedTimestamp { get; set; }
    }
}
