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

namespace CCommunicationPlatform2
{
    public partial class LogIn : Form
    {
        private Api api;

        public LogIn()
        {
            InitializeComponent();
            api = new Api();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "" || IDTxt.Text == "" || PswdTxt.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return;
            }

            if (IDTxt.Text.Length == 7)
            {
                Program.user.Role = "student";
            }
            else
            {
                Program.user.Role = "teacher";
            }

            Program.user.Account = this.NameTxt.Text;
            Program.user.No = Convert.ToInt32(this.IDTxt.Text);
            Program.user.Password = this.PswdTxt.Text;

            //bool loginSuccess=api.SignIn(Program.user);
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            int type;
            if (NameTxt.Text == "" || IDTxt.Text == "" || PswdTxt.Text == "")
            {
                MessageBox.Show("请输入完整信息！");
                return;
            }

            if (IDTxt.Text.Length == 7)
            {
                Program.user.Role = "student";
                type = 0;
            }
            else
            {
                Program.user.Role = "teacher";
                type = 1;
            }

            Program.user.Account = this.NameTxt.Text;
            Program.user.No = Convert.ToInt32(this.IDTxt.Text);
            Program.user.Password = this.PswdTxt.Text;

            api.SignUpUser(type, Program.user.No.ToString(), Program.user.Account, 
                "", "", "", Program.user.Password, Program.user.Account);

            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
