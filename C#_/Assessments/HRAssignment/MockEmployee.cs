using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAssignment
{

    internal class MockEmployeeDataReader : IEmployeeDataReader
    {
        public EmployeeRecord GetEmployeeRecord(int employeeId)
        {
            switch (employeeId)
            {
                case 101:
                    return new EmployeeRecord
                    {
                        Id = 101,
                        Name = "Akshay",
                        Role = "ASE",
                        IsVeteran = true
                    };
                case 102:
                    return new EmployeeRecord
                    {
                        Id = 102,
                        Name = "Kiran",
                        Role = "SE",
                        IsVeteran = false
                    };
                case 103:
                    return new EmployeeRecord
                    {
                        Id = 103,
                        Name = "Ram",
                        Role = "HR",
                        IsVeteran = false
                    };
                default:
                    return new EmployeeRecord
                    {
                        Id = employeeId,
                        Name = "Unknown",
                        Role = "Other",
                        IsVeteran = false
                    };
            }
        }
    }
}
