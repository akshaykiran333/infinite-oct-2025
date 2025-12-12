using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_netAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Connected Architecture


            ConnectArch obj = new ConnectArch();

            // obj.DisplayCourses();
            // obj.AddStudent();
            //obj.StudentsByDepartment();
            //obj.EnrolledCourse();
            //obj.UpdateGrade();


            //Disconnected Architecture
            DisConnArch obj2 = new DisConnArch();

            //obj2.LoadStudentCourses();
            //obj2.UpdateCredits();
            //obj2.InsertCourse();
           // obj2.DeleteStudent();

        }
    }
}
