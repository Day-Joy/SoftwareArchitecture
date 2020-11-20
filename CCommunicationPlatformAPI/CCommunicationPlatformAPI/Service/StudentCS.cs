using CCommunicationPlatformAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Service
{
    class StudentCS : CourseService
    {

        public void AddCourse(int user_id, Course course)
        {
            MysqlClient.AddRowInScource(user_id, course.Id);
        }

        public void DeleteCourse(int user_id, Course course)
        {
            MysqlClient.DeleteRowInScource(user_id, course.Id);
        }

        public void AlterCourse(Course course, int type)
        {
            Console.WriteLine("无权限");
        }

        public List<Course> QueryCourse()
        {
            return MysqlClient.Query();
        }

        public List<Course> QueryCourse(int uid)
        {
            var allId = MysqlClient.getCourseByStu(uid);
            IEnumerable<Course> result = new List<Course>();
            foreach (var i in allId)
            {
                result = result.Append(MysqlClient.getCourseById(i));
            }
            return result.ToList();
        }
    }
}
