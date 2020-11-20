using CCommunicationPlatformAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Service
{
    public interface CourseService
    {
        public void AddCourse(int user_id, Course course);
        public void DeleteCourse(int user_id, Course course);
        public void AlterCourse(Course course, int type);
        public List<Course> QueryCourse();
        public List<Course> QueryCourse(int uid);
    }
}
