using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrollment.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public int CId { get; set; }

        public int SId { get; set; }

        [NotMapped]
        public List<Country> countries { get; set; }
        [NotMapped]
        public List<Subject> subjects { get; set; }

    }

    public class Country
    {
        [Key]
        public int CId { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
    public class Subject
    {
        [Key]
        public int SId { get; set; }
        [Required]
        public string CourseName { get; set; }
    }
}
