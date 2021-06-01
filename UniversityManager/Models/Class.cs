using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityManager.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BeginDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string TeacherName { get; set; }

        [Required]
        [MaxLength(6)]
        public string Room { get; set; }
    }
}