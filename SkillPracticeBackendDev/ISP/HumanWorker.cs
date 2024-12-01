using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.ISP
{
    internal class HumanWorker : IWorkable, IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }

        public void Work()
        {
            Console.WriteLine("Human is working.");
        }
    }
}
