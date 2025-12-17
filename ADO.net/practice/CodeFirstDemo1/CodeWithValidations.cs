using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo1
{
    public class CodeWithValidations
    {
        Model1 dc = new Model1();

        public void insertnewstudents()
        {
            try
            {


                Student s = new Student()
                {
                    Studentid = 100,
                    Studentname = "Raj",
                    DOB = DateTime.Now,
                    Class = 10,
                    Email = "raj@gmail.com"
                };

                dc.Students.Add(s);
                int res = dc.SaveChanges();
                Console.WriteLine("total record inserted is " + res);
            }
            catch (Exception ex)
            {

                var res = dc.GetValidationErrors();

                foreach (var item in res)
                {
                    if (item.ValidationErrors.Count > 0)
                    {
                        foreach (var err in item.ValidationErrors)
                        {
                            Console.WriteLine(err.ErrorMessage);
                        }

                    }
                }

            }
        }
    }
}
