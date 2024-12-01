using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.DIP
{
    internal class SmsSender : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
