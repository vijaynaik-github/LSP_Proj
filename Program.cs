using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP.Interface;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employeeList = new List<IEmployee>();
            employeeList.Add(new ContractualEmployee());
            employeeList.Add(new CasualEmployee());
            foreach (Employee e in employeeList)
            {
                Console.WriteLine(e.GetEmployeeDetails(1245));
                Console.WriteLine(e.GetProjectDetails(67));
            }
            Console.ReadLine();
        }
    }
}
