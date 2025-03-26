using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL              //functions
{
	public class StudentDAL
	{

		public static List<StudentModel> GetStudents()
		{
			try
			{
                List<StudentModel> students = new List<StudentModel>();
                SqlConnection conn = DBHelper.GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Students", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    StudentModel student = new StudentModel();
                    student.Id=dr["Id"].ToString();
                    student.FullName=dr["FullName"].ToString();
                    student.Description=dr["Description"].ToString();
                    students.Add(student);
                }
                return students;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static void DeleteStudents(string id)
        {
            try
            {
                List<StudentModel> students = new List<StudentModel>();
                SqlConnection conn = DBHelper.GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Students where Id="+id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
