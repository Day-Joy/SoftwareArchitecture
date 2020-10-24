using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    class CourseServiceDecorator: CourseService
    {
        protected CourseService courseService;

        public CourseServiceDecorator(CourseService courseService)
        {
            this.courseService = courseService;
        }

        public void AddCourse(User user, Course course)
        {
            courseService.AddCourse(user, course);
        }

        public void DeleteCourse(User user, Course course)
        {
            courseService.DeleteCourse(user, course);
        }

        public void AlterCourse(Course course, int type)
        {
            courseService.AlterCourse(course, type);
        }

        public void QueryCourse()
        {
            courseService.QueryCourse();
        }
    }
}
