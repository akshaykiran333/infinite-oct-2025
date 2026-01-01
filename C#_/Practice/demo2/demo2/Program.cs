using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    internal class Program
    {

        // static void Main(string[] args)
        //ex of dynamic array size
        //{
        //    int rowsize, colsize;
        //    Console.WriteLine("Enter the number of rows ");
        //    rowsize = Convert.ToInt32(Console.ReadLine());
        //    colsize = 5;
        //    int[,] StudentMarks = new int[rowsize, colsize];
        //    for (int i = 0; i < rowsize; i++)
        //    {
        //        Console.WriteLine($"ENter the marks for student{i + 1}");
        //        for (int j = 0; j < colsize; j++)
        //        {
        //            Console.WriteLine($"Enter the marks for subject {j + 1}");
        //            StudentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
        //        }
        //    }
        //    Console.WriteLine("Displaying the marks of students ");
        //    for (int i = 0; i < rowsize; i++)
        //    {
        //        Console.WriteLine("\nstudent 1 marks are\n");
        //        int sum = 0;
        //        for (int j = 0; j < colsize; j++)
        //        {
        //            Console.Write(StudentMarks[i, j] + "\t");
        //            sum += StudentMarks[i, j];
        //        }
        //        Console.WriteLine("\n");
        //        Console.WriteLine("Total marks is: " + sum);
        //    }

        //    Console.ReadLine();
        //        int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
        //        foreach (int item in myArray)
        //            {
        //             Console.Write("item+\t");
        //            }
        //    Console.WriteLine("after reversed myArray is");
        //            Array.reverse(myArray);
        //             foreach (int item in myArray)
        //            {
        //        Console.WriteLine(item+"\t");
        //            }
        //Console.ReadLine();
        static void Main(string[] args)
        {

            //int[][] jaggedArray = new int[4][];

            //jaggedArray[0] = new int[2] { 1, 2};
            //jaggedArray[1] = new int[4] { 2, 3, 4, 7 };
            //jaggedArray[3] = new int[3] { 3, 8, 7 };
            //for (int i = 0; i < jaggedArray.Length; i++) 
            //{
            //    System.Console.Write("element({0}:,i+1");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        System.Console.Write(jaggedArray[i][j] + "\t");
            //    }
            //    System.Console.WriteLine();
            //}
            //Console.ReadLine();
            string[][] members = new string[][]
            {new string[] {"akshay","kiran" },
             new string[] {"john","sai","mani" }
                };
            for (int i = 0; i < members.Length; i++)
            {
                System.Console.WriteLine("name list({0}):", i + 1);
                for (int j = 0; j < members[i].Length; j++)
                {
                    System.Console.WriteLine(members[i][j] + "\t");

                }
                System.Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}