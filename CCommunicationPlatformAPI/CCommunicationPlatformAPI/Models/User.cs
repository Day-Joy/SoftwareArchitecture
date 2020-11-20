using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Models
{
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int No { get; set; }

        public string Password { get; set; }

        public string Account { get; set; }

        public string Role { get; set; }

        public User() { }
    }
}
