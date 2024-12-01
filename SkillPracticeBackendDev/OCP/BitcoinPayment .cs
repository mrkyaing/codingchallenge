using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.OCP
{
    internal class BitcoinPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Bitcoin payment...");
        }
    }
}
