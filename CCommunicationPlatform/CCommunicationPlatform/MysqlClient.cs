using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCommunicationPlatform
{
    public class MysqlClient
    {
        public static void LINQInDataSet()
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM scourse";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        DataRow[] rows = ds.Tables[0].Select();
                        for (int i = 0; i < rows.Length; i++)
                        {
                            Console.WriteLine($"{rows[i][0]},{rows[i][1]},{rows[i][2]}");
                        }
                    }
                }
            }
        }

        public static void EditInDataSet()
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM Books";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    MySqlCommandBuilder cmdBuilder =
                      new MySqlCommandBuilder(dataAdapter);
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        DataRow[] rows = ds.Tables[0].Select("AuthorId=6");
                        for (int i = 0; i < rows.Length; i++)
                        {
                            rows[i].BeginEdit();
                            rows[i][1] = 1;
                            rows[i].EndEdit();
                        }
                        dataAdapter.Update(ds);
                    }
                }
            }
        }

        public static void AddRowInScource(int user_id, int course_id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM scourse";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        DataRow newRow = ds.Tables[0].NewRow();
                        newRow[0] = user_id;
                        newRow[1] = course_id;
                        ds.Tables[0].Rows.Add(newRow);
                        dataAdapter.Update(ds);
                    }
                }
            }
        }

        public static void AddRowIncource(int user_id, Course course)
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM course";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        DataRow newRow = ds.Tables[0].NewRow();
                        newRow[1] = course.getName();
                        newRow[2] = course.getTeacher();
                        newRow[3] = course.getProgress();
                        newRow[4] = course.getKind();
                        newRow[5] = course.Representive;
                        ds.Tables[0].Rows.Add(newRow);
                        dataAdapter.Update(ds);
                    }
                }
            }
        }

        public static void DeleteRowInScource(int uid, int cid)
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "DELETE FROM scourse WHERE user_id = ?uid AND course_id = ?cid";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                mySqlCommand.Parameters.AddWithValue("@uid", uid);
                mySqlCommand.Parameters.AddWithValue("@cid", cid);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void DeleteRowIncource(int cid)
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "DELETE FROM course WHERE id = ?cid";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                mySqlCommand.Parameters.AddWithValue("@cid", cid);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void AlterRowIncource(Course course, int type)
        {
            using (MySqlConnection conn = GetConnection())
            {
                int id = course.id;
                string sql = "";
                string changeItem = "";
                switch (type)
                {
                    case 0: sql = "UPDATE course SET courseName = ?changeItem WHERE id = ?id"; changeItem = course.getName(); break;
                    case 1: sql = "UPDATE course SET progress = ?changeItem WHERE id = ?id"; changeItem = course.getProgress(); break;
                    case 2: sql = "UPDATE course SET kind = ?changeItem WHERE id = ?id"; changeItem = course.getKind(); break;
                    case 3: sql = "UPDATE course SET representive = ?changeItem WHERE id = ?id"; changeItem = course.Representive; break;
                }
                
                MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                mySqlCommand.Parameters.AddWithValue("@changeItem", changeItem);
                mySqlCommand.Parameters.AddWithValue("@id", id);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static Teacher getTeacher(string name)
        {
            MySqlDataReader result;
            Teacher teacher = new Teacher("", "");
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM user WHERE name = ?name AND type = 'teacher'"; 

                MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                mySqlCommand.Parameters.AddWithValue("@name", name);
                try
                {
                    result = mySqlCommand.ExecuteReader();
                    teacher = new Teacher(Convert.ToString(result.GetValue(2)), Convert.ToString(result.GetValue(1)));
                    if (result.GetValue(3) != null) { teacher.E_mail = Convert.ToString(result.GetValue(3)); }
                    if (result.GetValue(4) != null) { teacher.department = Convert.ToString(result.GetValue(4)); }
                    if (result.GetValue(5) != null) { teacher.special = Convert.ToString(result.GetValue(5)); }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return teacher;
        }

        public static List<object> Query(int flag, string filter = "")
        {
            List<object> results = new List<object>();
            String sql;
            switch (flag)
            {
                case 0: sql = "SELECT * FROM course"; break;//查询全部课程（通用）
                case 1: sql = "SELECT * FROM course WHERE teacherName =" + filter; break;//根据教师名（通用）
                case 2: sql = "SELECT * FROM scourse WHERE userId =" + Convert.ToInt32(filter); break;//查询某一学生所学全部课程（学生用）
                case 3: sql = "SELECT * FROM course WHERE courseName =" + filter; break;//根据课程名（通用）
                case 4: sql = "SELECT * FROM course WHERE courseKind =" + filter; break;//根据课程类型（学生用）
                default: return null;
            }
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            foreach (object field in row.ItemArray)
                            {
                                results.Add(field);
                                if (flag == 0)
                                {
                                    string nm = row[1].ToString();
                                    Teacher teacher = getTeacher(row[2].ToString());
                                    string prgs = row[3].ToString();
                                    string kind = row[4].ToString();
                                    Course course = new Course(nm, teacher.getName(), prgs, kind);
                                    Program.allCourses.Add(course);
                                }
                            }
                        }
                    }
                }
            }
            return results;
        }

        public static List<Course> FilterQuery(string kind)
        {
            List<Course> results = new List<Course>();
            Criteria criteria = null;
            switch (kind)
            {
                case "public": criteria = new CriteriaPublic(); break;
                case "specialized": criteria = new CriteriaSpecialized(); break;
                case "optional": criteria = new CriteriaOptional(); break;
                case "compulsory": criteria = new CriteriaCompulsory(); break;
            }
            results = criteria.MeetCriteria(Program.allCourses);
            return results;
        }


        private static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=1357924680;database=capus_communication;charset=utf8");
            connection.Open();
            return connection;
        }

        public static void QueryBooks()
        {
            Console.WriteLine("QueryAllBooks");
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM Books";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            foreach (object field in row.ItemArray)
                            {
                                Console.Write(field + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            //Console.WriteLine(ds.Tables[0].Rows[0][1]);
        }
    }
}
