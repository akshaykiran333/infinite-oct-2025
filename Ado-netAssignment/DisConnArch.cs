using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_netAssignment
{
    public class DisConnArch
    {
        SqlConnection connect = new SqlConnection(@"Integrated security=true;Database=Ado_net;server=(localdb)\MSSQLLocalDB");

        //Task 3.1 – Load Students and Courses into a DataSet
        //Show the data in tabular format.

        public void LoadStudentCourses()


        {
            try

            {
                SqlDataAdapter dca = null;

                connect.Open();

                dca = new SqlDataAdapter("Select * from Students", connect);

                DataSet ds = new DataSet();

                dca.Fill(ds, "Students");

                dca = new SqlDataAdapter("Select * from courses", connect);

                dca.Fill(ds, "Courses");

                Console.WriteLine("-----Student Details-----");

                DataTable students = ds.Tables["Students"];

                for (int i = 0; i < students.Rows.Count; i++)

                {

                    Console.WriteLine($"{students.Rows[i]["StudentId"]}  {students.Rows[i]["FullName"]}  {students.Rows[i]["Email"]}  {students.Rows[i]["Department"]}   {students.Rows[i]["YearOfStudy"]}");

                }

                Console.WriteLine("\n------Course Details--------");

                DataTable courses = ds.Tables["Courses"];

                for (int i = 0; i < courses.Rows.Count; i++)
                {
                    Console.WriteLine($"{courses.Rows[i]["CourseId"]}     {courses.Rows[i]["CourseName"]}    {courses.Rows[i]["Credits"]}    {courses.Rows[i]["Semester"]}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

        }
        //Task 3.2 Modify course credits(Disconnected Mode)
        //Steps: 
        //1. Load Courses into DataSet 
        //2. Ask user for CourseId 
        //3. Update Credits 
        //4. Use SqlCommandBuilder to update DB

        public void UpdateCredits()

        {
            SqlDataAdapter dca = null;
            DataSet dset = new DataSet();
            try
            {
                connect.Open();
                dca = new SqlDataAdapter("Select * From Courses", connect);
                SqlCommandBuilder builder = new SqlCommandBuilder(dca);
                dca.Fill(dset, "Courses");

                Console.Write("Enter CourseId to update credits: ");
                int courseId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Credits: ");
                int newCredits = Convert.ToInt32(Console.ReadLine());

                DataTable table = dset.Tables["Courses"];
                DataRow[] rows = table.Select($"CourseId = {courseId}");
                if (rows.Length > 0)
                {
                    rows[0]["Credits"] = newCredits;
                    dca.Update(dset, "Courses");
                    Console.WriteLine("Credits updated successfully");
                }
                else
                {
                    Console.WriteLine("Course not found");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //Task 3.3 – Insert a new course(Disconnected Mode)

        public void InsertCourse()

        {
            SqlDataAdapter dca = null;
            DataSet dset = new DataSet();

            try
            {
                connect.Open();
                dca = new SqlDataAdapter("SELECT * FROM Courses", connect);
                SqlCommandBuilder builder = new SqlCommandBuilder(dca);
                dca.Fill(dset, "Courses");

                Console.Write("Enter Course Name: ");
                string courseName = Console.ReadLine();

                Console.Write("Enter Credits: ");
                int credits = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Semester (Fall/Spring): ");
                string semester = Console.ReadLine();

                dset.Tables["Courses"].Rows.Add(null, courseName, credits, semester);
                dca.Update(dset, "Courses");
                Console.WriteLine("Course inserted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //Task 3.4 – Delete a student(Disconnected Mode)
        //Delete student record inside DataTable.

        public void DeleteStudent()
        {
            SqlDataAdapter dca = null;
            DataSet dset = new DataSet();
            try
            {
                connect.Open();
                dca = new SqlDataAdapter("Select * from students", connect);
                SqlCommandBuilder builder = new SqlCommandBuilder(dca);
                dca.Fill(dset, "Students");
                Console.Write("Enter StudentId to Delete: ");
                int studentId = Convert.ToInt32(Console.ReadLine());
                DataTable table = dset.Tables["Students"];
                DataRow[] rows = table.Select($"StudentId = {studentId}");

                if (rows.Length > 0)
                {

                    rows[0].Delete();
                    dca.Update(dset, "Students");
                    Console.WriteLine("Student deleted successfully");
                }
                else
                {
                    Console.WriteLine("Student id not found");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }

            finally
            {
                connect.Close();
            }

        }

    }
}
