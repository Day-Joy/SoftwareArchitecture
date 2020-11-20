using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    public interface CourseService
    {
        public void AddCourse(User user, Course course);
        public void DeleteCourse(User user, Course course);
        public void AlterCourse(Course course, int type);
        public void QueryCourse(string filter, int flag);
    }
}
