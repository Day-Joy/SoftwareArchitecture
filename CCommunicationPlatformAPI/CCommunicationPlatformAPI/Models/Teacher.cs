using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Models
{
    public class Teacher 
    {
        [Key]
        public string TeacherId { get; set; }

        public string Name { get; set; }        

        public string E_mail { get; set; }

        public string Academy { get; set; }

        public string Special { get; set; }

        public override string ToString()
        {
            return "id" + TeacherId + "\n姓名：" + Name + "\n邮箱：" + E_mail + "\n学院：" + Academy + "\n专业：" + Special + "\n";
        }
    }
}
