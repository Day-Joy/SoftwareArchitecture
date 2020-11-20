using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace CCommunicationPlatform2.Forms
{
    public partial class CourseCell : UserControl
    {
        private Api api;
        public MainWindow mainWindow;
        public CourseCell()
        {
            InitializeComponent();
            api = new Api();
            if (Program.user.Role == "teacher") EditButton.Enabled = true;
            else EditButton.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int Course_id = Convert.ToInt32(this.CidLbl.Text);
            string state;
            if (Program.user.Role == "student")
            {
                int User_id = Program.user.No;
                state = api.DeleteSCourseAsync(User_id, Course_id);
            }
            else
            {
                state = api.DeleteCourseAsync(Course_id);
            }
            if (state == "OK")
            {
                MessageBox.Show("Delete Success");
                mainWindow.ShowCourses();
            }
            else MessageBox.Show(state);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Forms.AddCourse addCourse = new Forms.AddCourse();
            addCourse.mainWindow = this.mainWindow;
            addCourse.AddCourseButton.Text = "Edit";
            addCourse.CourseNameTxt.Text = this.NameLbl.Text;
            addCourse.ProgressTxt.Text = this.ProgressLbl.Text;
            addCourse.KindTxt.Text = this.KindLbl.Text;
            addCourse.ReTxt.Text = this.RepreLbl.Text;
            addCourse.cid = Convert.ToInt32(this.CidLbl.Text);
            addCourse.ShowDialog();
        }
    }
}
