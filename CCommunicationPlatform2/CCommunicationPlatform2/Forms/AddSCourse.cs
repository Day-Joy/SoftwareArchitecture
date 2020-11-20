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
    public partial class AddSCourse : Form
    {
        public MainWindow mainWindow;
        private Api api;

        public AddSCourse()
        {
            InitializeComponent();
            api = new Api();
        }

        private async void AddSCourseButton_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            string url = $"User_id={Program.user.No}&Course_id={this.CourseIDTxt.Text}";
            //api.PostSCourseAsync(url);
            var data = new StringContent("", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:5001/api/Course/student/addCourse?" + url, data);

            string res = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(res);

            mainWindow.ShowCourses();
            this.Close();
        }
    }
}
