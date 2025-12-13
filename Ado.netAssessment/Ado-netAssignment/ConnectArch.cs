using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_netAssignment
{
    public class ConnectArch
    {
        SqlConnection connect = new SqlConnection(@"Integrated security=true;Database=Ado_net;server=(localdb)\MSSQLLocalDB");
        /*  
            Task 2.1 – Display all courses 
            Show: CourseId, CourseName, Credits, Semester  */

        public void DisplayCourses()

        {
            SqlDataReader ca = null;

            try
            {
                connect.Open();
                string sql = "SELECT CourseId, CourseName, Credits, Semester FROM Courses";
                SqlCommand cmd = new SqlCommand(sql, connect);
                ca = cmd.ExecuteReader();
                Console.WriteLine("CourseId   CourseName  Credits   Semester");
                while (ca.Read())
                {
                    Console.WriteLine(
                        ca["CourseId"] + "   " +
                        ca["CourseName"] + "      " +
                        ca["Credits"] + "        " +
                        ca["Semester"] );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.Message);
            }
            finally
            {
                if (ca != null)
                    ca.Close();

                connect.Close();
            }
        }
        //Task 2.2 – Add a new student 
        //        Input: 
        //• FullName 
        //• Email 
        //• Department 
        //• YearOfStudy
        public void AddStudent()

        {
            try
            {
                Console.Write("Enter the Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Email : ");
                string email = Console.ReadLine();
                Console.Write("Enter Department Name : ");
                string dept = Console.ReadLine();
                Console.Write("Enter Year of Studying : ");
                int year = Convert.ToInt32(Console.ReadLine());
                connect.Open();
                string sql = "INSERT INTO Students (FullName, Email, Department, YearOfStudy) " +
                             "VALUES (@FullName, @Email, @Dept, @Year)";

                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@FullName", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Dept", dept);
                cmd.Parameters.AddWithValue("@Year", year);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine("Student added successfully.");
                }
                else
                {
                    Console.WriteLine("No record inserted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        // Task 2.3 – Search students by department
        //Input example: “Computer Science” 
        //Display matching students.
        public void StudentsByDepartment()
        {
            SqlDataReader ca = null;

            try
            {
                Console.Write("Enter Department: ");
                string deptName = Console.ReadLine();
                connect.Open();
                string query = "SELECT StudentId, FullName, Email, YearOfStudy FROM Students WHERE Department = @d";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@d", deptName);
                ca = cmd.ExecuteReader();
                Console.WriteLine("\nStudents from " + deptName + ":");
                bool any = false;
                while (ca.Read())
                {
                    any = true;

                    Console.WriteLine(
                        ca["StudentId"] + "  " +
                        ca["FullName"] + "  " +
                        ca["Email"] + "  Year: " +
                        ca["YearOfStudy"]
                    );
                }
                if (!any)
                {
                    Console.WriteLine("No matching students found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (ca != null)
                    ca.Close();

                connect.Close();
            }
        }
        //Task 2.4 – Display enrolled courses for a student
        //Input: StudentId
        //Output example: 
        //Course Name | Credits | Enroll Date | Grade

        public void EnrolledCourse()
        {
            try
            {
                Console.Write("Enter the Student Id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                            "select c.CourseName, c.Credits, e.EnrollDate, e.Grade " +
                            "from Enrollments e inner join Courses c on e.CourseId = c.CourseId " +
                            "where e.StudentId = @id", connect); cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader ca = cmd.ExecuteReader();
                Console.WriteLine("\nEnrolled Courses for Student " + id);
                bool found = false;

                while (ca.Read())
                {
                    found = true;
                    Console.WriteLine($"{ca["CourseName"]}\t\t{ca["Credits"]}\t\t{ca["EnrollDate"]}\t\t{ca["Grade"]}");
                }

                if (!found)
                {
                    Console.WriteLine("No Course Enrolled ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }
        //Task 2.5 – Update grade(Connected Mode)
        //Input: 
        //• EnrollmentId 
        //• Grade(A/B/C/D/F)
        //Update Enrollments table.
        public void UpdateGrade()

        {
            try
            {
                Console.Write("Enter the Enrollment id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Grade : ");
                string grade = Console.ReadLine();
                connect.Open();
                SqlCommand cmd = new SqlCommand("update Enrollments set Grade = @grade where EnrollmentId = @id", connect);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@grade", grade);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Console.WriteLine("Grade Updated ");
                }
                else
                {
                    Console.WriteLine("Updation Failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                connect .Close();
            }
        }

    }
}


