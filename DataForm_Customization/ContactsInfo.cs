using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataForm_Customization
{
    public class ContactsInfo
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
