﻿using System;
using ContactsApp.Domain;

namespace Lecture2.Models
{
    public class ContactInfoModel
    {
        public ContactInfoModel(ContactInfo contactInfo)
        {
            if (contactInfo == null) throw new ArgumentNullException(nameof(contactInfo));
            _id = contactInfo.Id;
            Name = contactInfo.Name;
            PhoneNumber = contactInfo?.PrimaryPhoneNumber?.ToString();

        }

        private Guid? _id;

        public string Name { get; set; }
        public string PhoneNumber { get; set; }


    }
}