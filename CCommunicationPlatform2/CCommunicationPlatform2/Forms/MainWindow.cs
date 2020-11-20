using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCommunicationPlatform2
{
    public partial class MainWindow : Form
    {
        private Api api;
        List<Models.Courses> courses;
        List<Models.Courses> theCourses;

        public MainWindow()
        {
            InitializeComponent();
            api = new Api();
            courses = api.GetCoursesAsync();
            theCourses = new List<Models.Courses>();
            ShowCourses();
        }

        public void ShowCourses()
        {
            CoursePanel.Controls.Clear();
            if (Program.user.Role == "student")
            {
                theCourses = api.GetSCoursesAsync(Program.user.No);
            }
            else
            {
                if (courses != null)
                {
                    courses.ForEach(s => { if (s.TeacherName == Program.user.Account) theCourses.Add(s); });
                }
            }

            foreach (var course in theCourses)
            {
                Forms.CourseCell cell = new Forms.CourseCell();
                cell.mainWindow = this;
                cell.NameLbl.Text = course.CourseName;
                cell.CidLbl.Text = course.Id.ToString();
                cell.TeacherLbl.Text = course.TeacherName;
                cell.KindLbl.Text = course.Kind;
                cell.ProgressLbl.Text = course.Progress;
                cell.RepreLbl.Text = course.Representive;

                CoursePanel.Controls.Add(cell);
                cell.Dock = DockStyle.Top;
            }
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            if (Program.user.Role == "teacher")
            {
                Forms.AddCourse addCourse = new Forms.AddCourse();
                addCourse.AddCourseButton.Text = "Add";
                addCourse.mainWindow = this;
                addCourse.ShowDialog();
            }
            else
            {
                Forms.AddSCourse addSCourse = new Forms.AddSCourse();
                addSCourse.mainWindow = this;
                addSCourse.ShowDialog();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn log = new LogIn();
            log.Show();
        }
    }
}