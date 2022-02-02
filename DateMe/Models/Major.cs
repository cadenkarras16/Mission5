using System;
using System.ComponentModel.DataAnnotations;

namespace DateMe.Models
{
    public class Major
    {
        [Key]
        [Required]

        public int MajorID { get; set; }


        public string MajorName { get; set; }

    }
}
