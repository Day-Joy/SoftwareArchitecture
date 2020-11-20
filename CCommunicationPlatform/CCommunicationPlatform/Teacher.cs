using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    public class Teacher : User
    {
        public Teacher(string n, string p) : base(n, p) { }
        override public void LogIn(string n, string p)
        {
            Program.currentUser = new Teacher(n, p);
        }
    }

    public class TeacherDec : UserDec
    {
        public TeacherDec(Teacher teacher) : base(teacher) { }
        public void SetRepre(Course course, Student student)
        {
            course.Representive = student.getName();
        }
    }
}
