using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    class TeacherCs:CourseService
    {
        public void AddCourse(User user, Course course)
        {
            MysqlClient.AddRowIncource(user.Id, course);
        }

        public void DeleteCourse(User user, Course course)
        {
            MysqlClient.DeleteRowIncource(course.id);
        }

        public void AlterCourse(Course course, int type)
        {
            MysqlClient.AlterRowIncource(course, type);
        }

        public void QueryCourse(string filter, int flag)
        {
            if (flag == 2 || flag == 4)
            {
                Console.WriteLine("无权限");
                return;
            }
            MysqlClient.Query(flag, filter);
        }
    }
}
