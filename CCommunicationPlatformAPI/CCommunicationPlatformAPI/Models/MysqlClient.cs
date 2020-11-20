using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Models
{
    public class MysqlClient
    {
        public static SContext DB;
        public static Teacher getTeacher(string id)
        {
            Teacher teacher = new Teacher();
            var item = from t in DB.Teachers
                       where t.TeacherId == id
                       select t;
            foreach (var t in item)
            {
                teacher.Name = t.Name;
                teacher.Special = t.Special;
                teacher.E_mail = t.E_mail;
                teacher.Academy = t.Academy;
            }
            return teacher;
        }

        public static string AddRowInScource(int user_id, int course_id)
        {
            var item = DB.Scourses.Where(t => t.User_id == user_id && t.Course_id == course_id);
            if (item.Count() == 0)
            {
                try
                {
                    Scourse scourse = new Scourse();
                    scourse.Course_id = course_id;
                    scourse.User_id = user_id;
                    DB.Scourses.Add(scourse);
                    DB.SaveChanges();
                }
                catch (Exception e)
                {
                    return e.InnerException.Message;
                }

                return "success";
            }
            return "has existed";
        }
        
        public static string AddRowInCource(Course course)
        {
            var item = DB.Courses.Where(t => t.CourseName == course.CourseName && t.TeacherName == course.TeacherName);
            if (item.Count() == 0)
            {
                try
                {
                    DB.Courses.Add(course);
                    DB.SaveChanges();
                }
                catch (Exception e)
                {
                    return e.InnerException.Message;
                }

                return "success";
            }
            return "has existed";
        }

        public static string DeleteRowInScource(int uid, int cid)
        {
            try
            {
                var item = DB.Scourses.FirstOrDefault(t => t.User_id == uid && t.Course_id == cid);
                if(item != null)
                {
                    DB.Remove(item);
                    DB.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return e.InnerException.Message;
            }
            return "success";
        }

        public static List<Course> Query()
        {
            IQueryable<Course> query = DB.Courses;
            return query.ToList();
        }

        public static string DeleteRowInCource(int cid)
        {
            try
            {
                var item = DB.Courses.FirstOrDefault(t => t.Id == cid);
                if (item != null)
                {
                    DB.Remove(item);
                    DB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return e.InnerException.Message;
            }
            return "success";
        }

        public static string AlterRowInCource(Course course, int type)
        {
            try
            {
                var item = DB.Courses.FirstOrDefault(t => t.Id == course.Id);
                if(item != null)
                {
                    switch (type)
                    {
                        case 0: item.CourseName = course.CourseName; break;
                        case 1: item.Progress = course.Progress; break;
                        case 2: item.Kind = course.Kind; break;
                        case 3: item.Representive = course.Representive; break;
                    }
                    DB.SaveChanges();
                }               
            }
            catch (Exception e)
            {
                return e.InnerException.Message;
            }
            return "success";
        }

        public static Course getCourseById(int cid)
        {
            var item = DB.Courses.FirstOrDefault(t => t.Id == cid);
            if (item != null)
            {
                return item;
            }
            else return null;
        }

        public static int[] getCourseByStu(int uid)
        {
            var item = DB.Scourses.Where(t => t.User_id == uid);
            var number = item.Count();
            int[] result = new int[number];
            int j = 0;
            foreach (var i in item)
            {
                result[j] = i.Course_id;
                j++;
            }
            return result;
        }

        public static int Resgister(int type, string id, string name, string e_mail, string academy, string special, string password, string nickname)
        {
            if (type == 0 && !isExisted(Convert.ToInt32(id)))
            {
                Student student = new Student();
                student.StudentId = id;
                student.Name = name;
                student.E_mail = e_mail;
                student.Academy = academy;
                student.Special = special;
                DB.Students.Add(student);
                User user = new User();
                user.Password = password;
                user.Role = "student";
                user.Account = id;
                DB.Users.Add(user);
                DB.SaveChanges();
                return 0;
            }
            else
            {
                Teacher teacher = new Teacher();
                teacher.TeacherId = id;
                teacher.Name = name;
                teacher.E_mail = e_mail;
                teacher.Academy = academy;
                teacher.Special = special;
                DB.Teachers.Add(teacher);
                User user = new User();
                user.Password = password;
                user.Role = "teacher";
                user.Account = id;
                DB.Users.Add(user);
                DB.SaveChanges();
                return 1;
            }
        }

        private static bool isExisted(int id)
        {
            var item = DB.Users.FirstOrDefault(t => t.No == id);
            if (item == null) return false;
            return true;
        }

        public static int Login(string id, string password)
        {
            var item = DB.Users.Where(t => t.Account == id && t.Password == password);
            if (item != null) return 0;
            return 1;
        }
    }
}
