using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    class StudentCS: CourseService
    {

        public void AddCourse(User user, Course course)
        {
            MysqlClient.AddRowInScource(user.Id, course.id);
        }

        public void DeleteCourse(User user, Course course)
        {
            MysqlClient.DeleteRowInScource(user.Id, course.id);
        }

        public void AlterCourse(Course course, int type)
        {
            Console.WriteLine("无权限");
        }

        public void QueryCourse(string filter, int flag)
        {
            MysqlClient.Query(flag, filter);
        }
    }
}
