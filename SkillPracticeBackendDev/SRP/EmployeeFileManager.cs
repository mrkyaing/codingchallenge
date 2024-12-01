using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.SRP
{
    // 3. Class for File Management
    internal class EmployeeFileManager
    {
        public void SaveToFile(Employee employee, string fileName)
        {
            File.WriteAllText(fileName, $"Employee: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}
