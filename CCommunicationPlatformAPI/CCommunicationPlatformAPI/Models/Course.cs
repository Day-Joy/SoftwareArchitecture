using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Models
{
    public class Course
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string TeacherName { get; set; }

        public string Progress { get; set; }

        public string Kind { get; set; }

        public string Representive { get; set; }
    }
}
