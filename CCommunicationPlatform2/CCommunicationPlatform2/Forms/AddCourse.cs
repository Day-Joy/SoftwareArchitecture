using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace CCommunicationPlatform2.Forms
{
    public partial class AddCourse : Form
    {
        
        public int cid;
        public MainWindow mainWindow;

        private Api api;
        private int kind;
        private string change;

        public AddCourse()
        {
            InitializeComponent();
            api = new Api();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (AddCourseButton.Text == "Add") //教师添加课程
            {
                string url = $"courseName={this.CourseNameTxt.Text}&teacherName={Program.user.Account}" +
                    $"&progress={this.ProgressTxt.Text}&kind={this.KindTxt.Text}&representive={this.ReTxt.Text}";
                api.PostCourseAsync(url);
                
            }
            else //教师修改课程信息
            {
                string url = $"cid={cid}&change={change}&type={kind}";
                api.PutCourseAsync(url);
            }
            mainWindow.ShowCourses();
            this.Close();
        }

        private void CourseNameTxt_TextChanged(object sender, EventArgs e)
        {
            kind = 0;
            change = CourseNameTxt.Text;
        }

        private void ProgressTxt_TextChanged(object sender, EventArgs e)
        {
            kind = 1;
            change = ProgressTxt.Text;
        }

        private void KindTxt_TextChanged(object sender, EventArgs e)
        {
            kind = 2;
            change = KindTxt.Text;
        }

        private void ReTxt_TextChanged(object sender, EventArgs e)
        {
            kind = 3;
            change = ReTxt.Text;
        }
    }
}
