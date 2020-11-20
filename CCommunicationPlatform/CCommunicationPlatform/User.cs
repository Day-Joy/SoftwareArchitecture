using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    public interface UserOp
    {
        void LogIn(string n, string p);
        void LogOut();
    }

    public abstract class User : UserOp
    {
        //字段
        protected int id; //学工号
        protected string pswd; //密码
        protected string name; //姓名

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //属性
        public string E_mail { get; set; } //邮箱
        public string department { get; set; } //所属学院
        public string special { get; set; } //专业，擅长领域
        public List<Course> CourseList { get; set; } //课程表

        public User(string n, string p)
        {
            this.name = n;
            this.pswd = p;
        }

        public abstract void LogIn(string n, string p);
        public void LogOut()
        {
            Program.currentUser = null;
        }
        public string getName() { return name; }
    }

    public abstract class UserDec : UserOp
    {
        protected User user;

        public UserDec(User usr) { this.user = usr; }
        public void LogIn(string n, string p)
        {
            user.LogIn(n, p);
        }
        public void LogOut()
        {
            user.LogOut();
        }
    }
}
