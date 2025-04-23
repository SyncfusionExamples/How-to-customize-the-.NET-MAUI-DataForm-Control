using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataForm_Customization
{
    public class ContactsInfo
    {
        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; }
    }
}
