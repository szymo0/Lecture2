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

        }

        public Guid? Id { get; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }


    }
}
