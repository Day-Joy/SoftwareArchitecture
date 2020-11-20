using CCommunicationPlatformAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Service
{
    class CourseServiceDecorator : CourseService
    {
        protected CourseService courseService;

        public CourseServiceDecorator(CourseService courseService)
        {
            this.courseService = courseService;
        }

        public void AddCourse(int user_id, Course course)
        {
            courseService.AddCourse(user_id, course);
        }

        public void DeleteCourse(int user_id, Course course)
        {
            courseService.DeleteCourse(user_id, course);
        }

        public void AlterCourse(Course course, int type)
        {
            courseService.AlterCourse(course, type);
        }

        public List<Course> QueryCourse()
        {
            return courseService.QueryCourse();
        }

        public List<Course> QueryCourse(int uid)
        {
            return courseService.QueryCourse(uid);
        }
    }
}
