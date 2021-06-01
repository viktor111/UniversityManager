using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UniversityManager.Models.Enums;

namespace UniversityManager.Models
{
    public class Semester
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Number { get; set; }

        [Required]
        public DateTime BeginDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public SemesterNumber SemesterNumber { get; set; }

        public virtual IEnumerable<Class> Classes { get; set; }
            = new HashSet<Class>();

        public virtual IEnumerable<Student> EnrolledStudents { get; set; }
            = new HashSet<Student>();
    }
}