using System.ComponentModel.DataAnnotations;
using Form.Enums;

namespace Form.Models
{
    public class FormModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool DoNotHaveIDNumber { get; set; }
        public string? IDNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public Nationality Nationality { get; set; }
        public bool GDPR { get; set; }
    }
}
