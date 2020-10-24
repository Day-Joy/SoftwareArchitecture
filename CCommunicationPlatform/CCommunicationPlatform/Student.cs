using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    public class Student : User
    {
        public Student(string n, string p) : base(n, p) { }
        override public void LogIn(string n, string p)
        {
            Program.currentUser = new Student(n, p);
        }

        public override string ToString()
        {
            return "id" + id + "\n姓名：" + name + "\n邮箱：" + E_mail + "\n学院：" + department + "\n专业：" + special + "\n课程：\n" + CourseList;
        }
    }

    public class StudentDec : UserDec
    {
        public StudentDec(Student student) : base(student) { }
        public void ApplyForRepre(Course course)
        {
            UserOp teacherOp = new TeacherDec(MysqlClient.getTeacher(course.getTeacher()));
            ((TeacherDec)teacherOp).SetRepre(course, (Student)this.user);
        }
    }
}
