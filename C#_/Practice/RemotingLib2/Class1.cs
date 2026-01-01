using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemotingTrn2;

namespace RemotingLib2
{
    [Serializable]
    public class ServiceClass : MarshalByRefObject, IMyinter

    {

        private readonly Dictionary<int, Student> students = new Dictionary<int, Student>

        {

            [1] = new Student { Id = 1, Name = "Akshay", Class = "10th", TotalMarks = 450 },

            [2] = new Student { Id = 2, Name = "Kiran", Class = "9th", TotalMarks = 380 },

            [3] = new Student { Id = 3, Name = "Ravi", Class = "8th", TotalMarks = 290 },

            [4] = new Student { Id = 4, Name = "Sai", Class = "10th", TotalMarks = 500 }

        };

        public void ShowAllStudents()

        {

            Console.WriteLine("----- All Students -----");

            foreach (var s in students.Values)

            {

                Console.WriteLine(s);

            }

        }

        public Student GetStudent(int id)

        {

            if (!students.ContainsKey(id))

            {

                Console.WriteLine("ID not found — returning default.");

                return new Student

                {

                    Id = 0,

                    Name = "Unknown",

                    Class = "N/A",

                    TotalMarks = 0

                };

            }

            Student std = students[id];

            if (std.TotalMarks < 300)

            {

                throw new Exception($"Marks too low ({std.TotalMarks}). Student failed.");

            }

            return std;

        }

    }


}
