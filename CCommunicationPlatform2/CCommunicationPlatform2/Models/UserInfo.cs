using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CCommunicationPlatform2.Models
{
    class UserInfo
    {
        [JsonProperty("No")]
        public int No { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Account")]
        public string Account { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        override public string ToString()
        {
            return $"id={No}&password={Password}";
        }
    }

    class Student
    {
        [JsonProperty("StudentId")]
        public string StudentId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("E_mail")]
        public string E_mail { get; set; }

        [JsonProperty("Academy")]
        public string Academy { get; set; }

        [JsonProperty("Special")]
        public string Special { get; set; }
    }

    class Teacher
    {
        [JsonProperty("TeacherId")]
        public string TeacherId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("E_mail")]
        public string E_mail { get; set; }

        [JsonProperty("Academy")]
        public string Academy { get; set; }

        [JsonProperty("Special")]
        public string Special { get; set; }
    }
}
