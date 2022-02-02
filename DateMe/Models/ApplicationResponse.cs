using System;
using System.ComponentModel.DataAnnotations;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Hey, you fool you need to enter a lastname!")]
        public string LastName { get; set; }

        public byte Age { get; set; }
        [Required(ErrorMessage ="typical phone numbe is (###) - ### - ####, C 'mon son! ")]
        [Phone]
        public string Phone { get; set; }

        public bool CreeperStalker { get; set; }

        //Build the foreign key relationship

        public int MajorID { get; set; }
        public Major Major { get; set; }
    }
}
