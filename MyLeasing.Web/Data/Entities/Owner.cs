using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "The Field {0} is Mandatory")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Document*")]
        public string Document { get; set; }

        [Required(ErrorMessage = "The Field {0} is Mandatory")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "First Name*")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Field {0} is Mandatory")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Last Name*")]
        public string LastName { get; set; }

        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [Required(ErrorMessage = "The Field {0} is Mandatory")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters")]
        [Display(Name = "Cell Phone*")]
        public string CellPhone { get; set; }


        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters")]
        public string Address { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";
        [Display(Name = "Full Name With Document")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
