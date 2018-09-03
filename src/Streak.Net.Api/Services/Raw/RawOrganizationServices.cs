using System;
using System.Web;
using Newtonsoft.Json;
using Streak.Net.Api.Enums;
using Streak.Net.Api.Models;

namespace Streak.Net.Api.Services.Raw
{
    public class RawOrganizationServices : RawServicesBase
    {
        internal RawOrganizationServices(string apiKey, string apiBaseUrl) : base(apiKey, apiBaseUrl) { }

        public RawApiResponse GetOrganization(string organizationKey)
        {
            int httpStatusCode;
            var json = Http.Get(ApiHandles.GetOrganization.Replace("{organizationKey}", organizationKey), out httpStatusCode);
            return RawStreakApiResponseFactory.BuildRawStreakApiResponse(json, httpStatusCode);
        }
    }
}
