using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;

namespace CCommunicationPlatform2
{
    class Api
    {
        public enum StatusCode
        {
            Created,                  //表明创建成功
            Conflict,                 //表明创建重复
            OK,                       //200
        }
        public const string baseurl = "https://localhost:5001/api/Course/";
        public const string APIKey = "INSERT_API_KEY_HERE";
        private static HttpClient HttpClient;
        private static Regex rx;
        public static string Token;
        static Api()
        {
            HttpClient = new HttpClient();
            string pattern;
            pattern = @"token"":""(.*)""}";
            rx = new Regex(pattern, RegexOptions.Compiled);

        }

        //注册
        public string SignUpUser(int type, string id, string name, string e_mail, 
            string academy, string special, string password, string nickname)
        {
            HttpContent content = new StringContent(" ",Encoding.UTF8, "application/json");
            string url = $"type={type}&id={id}&name={name}&e_mail={e_mail}&academy={academy}&special={special}&password={password}&nickname={nickname}";
            var x = HttpClient.PostAsync(baseurl + "register?" + url, content).Result;
            return x.StatusCode.ToString();
        }
        //登录
        public bool SignIn(Models.UserInfo user)
        {
            HttpContent content = new StringContent(" ", Encoding.UTF8, "application/json");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");
            var x = HttpClient.PostAsync(baseurl + "login?" + user.ToString(), content).Result;
            if (x.StatusCode.ToString() == "OK")
            {
                Token = rx.Match(x.Content.ReadAsStringAsync().Result).Groups[1].Value;
                return true;
            }
            else
            {
                return false;
            }
        }

        //获取全部课程
        public List<Models.Courses> GetCoursesAsync()
        {
            List<Models.Courses> courses = null;
            try
            {
                HttpResponseMessage x = HttpClient.GetAsync("https://localhost:5001/api/Course/search").Result;
                string tempdata = x.Content.ReadAsStringAsync().Result;
                courses = JsonConvert.DeserializeObject<List<Models.Courses>>(tempdata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return courses;
        }

        //教师新加课程
        public string PostCourseAsync(Models.PostSCourse postcourse)
        {
            string json = JsonConvert.SerializeObject(postcourse);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage x = HttpClient.PostAsync(baseurl + "teacher/addCourse?", content).Result;
            return x.StatusCode.ToString();
        }
        public async void PostCourseAsync(string url)
        {
            var client = new HttpClient();
            var data = new StringContent("", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:5001/api/Course/teacher/addCourse?" + url, data);
            string res = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(res);
        }

        //教师删除课程
        public string DeleteCourseAsync(int Course_id)
        {
            HttpResponseMessage x = HttpClient.DeleteAsync(baseurl + "teacher/deleteCourse?" + "Course_id=" + Course_id).Result;
            return x.StatusCode.ToString();
        }

        //教师修改课程
        public string PutCourseAsync(string course, int id, Models.PostSCourse postcourse)
        {
            string json = JsonConvert.SerializeObject(postcourse);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage x = HttpClient.PutAsync(baseurl + "teacher/alterCourse?" + "id=" + id + "&token=" + course, content).Result;
            return x.StatusCode.ToString();
        }
        public async void PutCourseAsync(string url)
        {
            var client = new HttpClient();
            var data = new StringContent("{change:a,type:b}", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:5001/api/Course/teacher/alterCourse?" + url, data);
            string res = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(res);
        }

        //获取学生全部课程
        public List<Models.Courses> GetSCoursesAsync(int uid)
        {
            List<Models.Courses> scourses = null;
            try
            {
                HttpResponseMessage x = HttpClient.GetAsync("https://localhost:5001/api/Course/student/searchCourse?uid=" + uid).Result;
                string tempdata = x.Content.ReadAsStringAsync().Result;
                scourses = JsonConvert.DeserializeObject<List<Models.Courses>>(tempdata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return scourses;
        }

        //学生新加课程
        public string PostSCourseAsync(Models.PostSCourse postcourse)
        {
            string json = JsonConvert.SerializeObject(postcourse);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage x = HttpClient.PostAsync(baseurl + "student/addCourse?", content).Result;
            return x.StatusCode.ToString();
        }
        public async void PostSCourseAsync(string url)
        {
            var client = new HttpClient();
            var data = new StringContent("", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:5001/api/Course/student/addCourse?" + url, data);

            string res = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(res);
        }

        //学生撤课
        public string DeleteSCourseAsync(int User_id, int Course_id)
        {
            HttpResponseMessage x = HttpClient.DeleteAsync(baseurl + "student/deleteCourse?" + "User_id=" + User_id + "&Course_id=" + Course_id).Result;
            return x.StatusCode.ToString();
        }
    }
}
