using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streak.Net.Api.Models
{
    public class Person
    {
        public string email;
        public string isGoogleContact;
        public string imageUrl;
        public string displayName;

        public Person(string email) : this(email, true, "https://mailfoogae.appspot.com/images/NoPicture.jpg", email) { }

        public Person(string email, bool isGoogleContact, string imageUrl, string displayName)
        {
            this.email = email;
            this.isGoogleContact = isGoogleContact.ToString().ToLower();
            this.imageUrl = imageUrl;
            this.displayName = displayName;
        }
    }
}
