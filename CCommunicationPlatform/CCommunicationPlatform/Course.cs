using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCommunicationPlatform
{
	public class Course
	{
        string courseName; //课程名
		string teacherName; //授课教师
		string progress; //课程进度
		string kind; //课程类型
		string representiveName; //课代表

        public int id { get; set; }

        public string Representive
        {
			get { return representiveName; }
			set { representiveName = value; }
        }

		//构造方法
		public Course(string nm, string tch, string prgs, string kind)
		{
			this.courseName = nm;
			this.teacherName = tch;
			this.progress = prgs;
			this.kind = kind;
		}

		//提供课程信息
		//public int getID() { return courseID; }
		public string getName() { return courseName; }
		public string getTeacher() { return teacherName; }
		public string getKind() { return kind; }
		public string getProgress() { return progress; }
        //public Student getRepresentive() { return representive; }

        public override string ToString()
        {
            return "id:" + id + "\n课程名：" + courseName + "\n教师名：" + teacherName + "\n进度：" + progress + "\n类型" + kind + "\n课代表：" + representiveName + "\n";
        }
    }

}



