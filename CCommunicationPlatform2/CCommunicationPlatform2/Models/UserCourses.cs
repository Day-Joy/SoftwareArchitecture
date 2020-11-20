using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CCommunicationPlatform2.Models
{
    public class Courses
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("CourseName")]
        public string CourseName { get; set; }

        [JsonProperty("TeacherName")]
        public string TeacherName { get; set; }

        [JsonProperty("Progress")]
        public string Progress { get; set; }

        [JsonProperty("Kind")]
        public string Kind { get; set; }

        [JsonProperty("Representive")]
        public string Representive { get; set; }
    }

    public class PostCourse
    {
        [JsonProperty("CourseName")]
        public string CourseName { get; set; }

        [JsonProperty("TeacherName")]
        public string TeacherName { get; set; }

        [JsonProperty("Progress")]
        public string Progress { get; set; }

        [JsonProperty("Kind")]
        public string Kind { get; set; }

        [JsonProperty("Representive")]
        public string Representive { get; set; }
    }

    public class PostSCourse
    {
        [JsonProperty("User_id")]
        public int User_id { get; set; }

        [JsonProperty("Course_id")]
        public int Course_id { get; set; }
    }
}
