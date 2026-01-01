using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\New folder\\text.txt";

            //writing to a file

            using (StreamWriter writer = new StreamWriter(filePath))
            {

                writer.WriteLine("Hello World!!!");
                writer.WriteLine("This is a sample text file!!!");
            }

            // Reading from a file
            using (StreamReader reader = new StreamReader(filePath))
            {
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("File content");
                    Console.WriteLine(content);
                }
                
                //Appending to a file

                using (StreamWriter writer = new StreamWriter(filePath,true))
                {
                    writer.WriteLine("Appending a new line to the file");
                }

                //Reading the updated file

                using (StreamReader read = new StreamReader(filePath))
                {
                    string content= read.ReadToEnd();
                    Console.WriteLine("updated file context");
                    Console.WriteLine(content);
                }
                Console.ReadLine();
            }
        }
    }
}
