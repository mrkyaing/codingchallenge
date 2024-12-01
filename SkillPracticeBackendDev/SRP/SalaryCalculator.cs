using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.SRP
{
    // 2. Class for Salary Calculation
    internal class SalaryCalculator
    {
        public decimal CalculateMonthlySalary(Employee employee)
        {
            return employee.Salary / 12;
        }
    }
}
