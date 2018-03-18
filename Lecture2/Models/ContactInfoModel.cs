using System;
using ContactsApp.Domain;

namespace Lecture2.Models
{
    public class ContactInfoModel
    {
        public ContactInfoModel(ContactInfo contactInfo)
        {
            if (contactInfo == null) throw new ArgumentNullException(nameof(contactInfo));
            Id = contactInfo.Id;
            Name = contactInfo.Name;
            PhoneNumber = contactInfo?.PrimaryPhoneNumber?.ToString();
            FirstName = contactInfo.PersonalData?.FirstNames?.ToString();
            LastName = contactInfo.PersonalData?.LastNames?.ToString();

        }

        public Guid? Id { get; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
