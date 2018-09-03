using System;
using System.Web;
using Newtonsoft.Json;
using Streak.Net.Api.Enums;
using Streak.Net.Api.Models;

namespace Streak.Net.Api.Services.Raw
{
    public class RawContactServices: RawServicesBase
    {
        internal RawContactServices(string apiKey, string apiBaseUrl) : base(apiKey, apiBaseUrl) { }

        public RawApiResponse GetContact(string contactKey)
        {
            int httpStatusCode;
            var json = Http.Get(ApiHandles.GetContact.Replace("{contactKey}", contactKey), out httpStatusCode);
            return RawStreakApiResponseFactory.BuildRawStreakApiResponse(json, httpStatusCode);
        }
    }
}
