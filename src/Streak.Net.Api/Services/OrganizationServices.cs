using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Streak.Net.Api.Enums;
using Streak.Net.Api.Models;
using Streak.Net.Api.Services.Raw;

namespace Streak.Net.Api.Services
{
    public class OrganizationServices : ServicesBase
    {
        private readonly RawOrganizationServices _rawOrganizationServices;

        internal OrganizationServices(string apiKey, string apiBaseUrl, bool includeRawResponse) : base(includeRawResponse)
        {
            _rawOrganizationServices = new RawOrganizationServices(apiKey, apiBaseUrl);
        }

        public Organization GetOrganization(string organizationKey)
        {
            var rawResponse = _rawOrganizationServices.GetOrganization(organizationKey);
            var organization = JsonConvert.DeserializeObject<Organization>(rawResponse.Json);
            organization.RawApiResponse = GetRawApiResponseOrNull(rawResponse);
            return organization;
        }
    }
}
