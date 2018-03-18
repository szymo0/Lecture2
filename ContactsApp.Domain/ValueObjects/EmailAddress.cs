using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ContactsApp.Domain.Shared;
using ContactsApp.Domain.ValueObjects.Exceptions;

namespace ContactsApp.Domain.ValueObjects
{
    public class EmailAddress:ValueObject<EmailAddress>
    {
        private readonly Regex _emailValidator=new Regex(Consts.EmailAdress,RegexOptions.Compiled);
        public string Email { get; }
        public EmailAddress(string emailAddress)
        {
            Email = emailAddress ?? throw new ArgumentNullException(nameof(emailAddress));
            if(!_emailValidator.IsMatch(Email)) throw new InvalidEmailAddressFormat(Email);
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Email;
        }

        public override string ToString()
        {
            return Email;
        }
    }
}
