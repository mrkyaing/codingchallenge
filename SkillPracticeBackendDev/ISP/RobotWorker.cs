using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.ISP
{
    internal class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
