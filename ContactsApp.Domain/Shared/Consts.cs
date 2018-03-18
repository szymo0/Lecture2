namespace ContactsApp.Domain.Shared
{
    public static class Consts
    {
        public static string PhoneRegex = @"/^(?:\(?\+?\d{2})?(?:[-\.\(\)\s]*(\d)){9}\)?$/";

        public static string EmailAdress =
            @"^(?("")("".+?(?<!\\)""@)|(([0 - 9a - z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        public const int DefaultSizeOfAltenrativeCollection = 4;
    }
}
