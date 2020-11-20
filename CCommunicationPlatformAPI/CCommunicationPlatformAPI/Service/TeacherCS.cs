using CCommunicationPlatformAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Service
{
    class TeacherCS : CourseService
    {
        public void AddCourse(int user_id, Course course)
        {
            MysqlClient.AddRowInCource(course);
        }

        public void DeleteCourse(int user_id, Course course)
        {
            MysqlClient.DeleteRowInCource(course.Id);
        }

        public void AlterCourse(Course course, int type)
        {
            MysqlClient.AlterRowInCource(course, type);
        }
        public List<Course> QueryCourse()
        {
            return MysqlClient.Query();
        }

        public List<Course> QueryCourse(int uid)
        {
            return MysqlClient.Query();
        }
    }
}
