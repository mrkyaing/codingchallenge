using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.DIP
{
    internal class EmailSender : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
}
