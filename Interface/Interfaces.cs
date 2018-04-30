using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Interface
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IProject
    {
        string GetProjectDetails(int employeeId);
    }
}
