using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using CCommunicationPlatformAPI.Models;
using CCommunicationPlatformAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCommunicationPlatformAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private SContext db;
        
        public CourseController(SContext context)
        {
            this.db = context;
            MysqlClient.DB = context;
        }

        [HttpGet("search")]
        public List<Course> GetAll()
        {
            return MysqlClient.Query();
        }

        [HttpPost("student/addCourse")]
        public IActionResult AddNew(int user_id, int course_id)
        {
            StudentCS studentCS = new StudentCS();
            CourseServiceDecorator courseServiceDecorator = new CourseServiceDecorator(studentCS);
            Course course = new Course();
            course = MysqlClient.getCourseById(course_id);
            courseServiceDecorator.AddCourse(user_id, course);
            return Ok(db.Scourses);
        }

        [HttpDelete("student/deleteCourse")]
        public IActionResult DeleteNew(int user_id, int course_id)
        {
            StudentCS studentCS = new StudentCS();
            CourseServiceDecorator courseServiceDecorator = new CourseServiceDecorator(studentCS);
            Course course = new Course();
            course = MysqlClient.getCourseById(course_id);
            courseServiceDecorator.DeleteCourse(user_id, course);
            return Ok(db.Scourses);
        }

        [HttpPost("teacher/addCourse")]
        public IActionResult AddNewCourse(string courseName, string teacherName, string progress, string kind, string representive)
        {
            TeacherCS teacherCS = new TeacherCS();
            CourseServiceDecorator courseServiceDecorator = new CourseServiceDecorator(teacherCS);
            Course course = new Course();
            course.CourseName = courseName;
            course.TeacherName = teacherName;
            course.Progress = progress;
            course.Kind = kind;
            course.Representive = representive;
            courseServiceDecorator.AddCourse(1, course);
            return Ok(db.Courses);
        }

        [HttpDelete("teacher/deleteCourse")]
        public IActionResult DeleteCourse(int course_id)
        {
            TeacherCS teacherCS = new TeacherCS();
            CourseServiceDecorator courseServiceDecorator = new CourseServiceDecorator(teacherCS);
            Course course = MysqlClient.getCourseById(course_id);
            courseServiceDecorator.DeleteCourse(1, course);
            return Ok(db.Courses);
        }

        [HttpPost("teacher/alterCourse")]
        public IActionResult AlterNew(int cid, string change, int type)
        {
            TeacherCS teacherCS = new TeacherCS();
            CourseServiceDecorator courseServiceDecorator = new CourseServiceDecorator(teacherCS);
            Course course = MysqlClient.getCourseById(cid);
            switch (type)
            {
                case 0: course.CourseName = change; break;
                case 1: course.Progress = change; break;
                case 2: course.Kind = change; break;
                case 3: course.Representive = change; break;
            }
            courseServiceDecorator.AlterCourse(course, type);
            return Ok(db.Courses);
        }

        [HttpGet("student/searchCourse")]
        public List<Course> GetCourse(int uid)
        {
            StudentCS studentCS = new StudentCS();
            CourseServiceDecorator courseServiceDecorator = new CourseServiceDecorator(studentCS);
            return courseServiceDecorator.QueryCourse(uid);
        }

        [HttpPost("register")]
        public int Resgister(int type, string id, string name, string e_mail, string academy, string special, string password, string nickname)
        {
            return MysqlClient.Resgister(type, id, name, e_mail, academy, special, password, nickname);
        }

        [HttpGet("login")]
        public static int Login(string id, string password)
        {
            var item = MysqlClient.DB.Users.Where(t => t.Account == id && t.Password == password);
            if (item != null) return 0;
            return 1;
        }
    }
}
