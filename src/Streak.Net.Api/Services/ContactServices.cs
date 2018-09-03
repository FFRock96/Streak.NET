using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Streak.Net.Api.Enums;
using Streak.Net.Api.Models;
using Streak.Net.Api.Services.Raw;

namespace Streak.Net.Api.Services
{
    public class ContactServices: ServicesBase
    {
        private readonly RawContactServices _rawContactServices;

        internal ContactServices(string apiKey, string apiBaseUrl, bool includeRawResponse) : base(includeRawResponse)
        {
            _rawContactServices = new RawContactServices(apiKey, apiBaseUrl);
        }

        public Contact GetContact(string contactKey)
        {
            var rawResponse = _rawContactServices.GetContact(contactKey);
            var contact = JsonConvert.DeserializeObject<Contact>(rawResponse.Json);
            contact.RawApiResponse = GetRawApiResponseOrNull(rawResponse);
            return contact;
        }
    }
}
