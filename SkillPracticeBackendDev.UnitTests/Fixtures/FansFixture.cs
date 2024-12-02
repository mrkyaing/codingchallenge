using AWebsite.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.UnitTests.Fixtures
{
    public   class FansFixture
    {
        public static List<Fan> GetFans() {
            return new List<Fan>() {
            new Fan()
            {
                Id = 1,
                Name = "Test",
                Email="test@mail"
            }
        };
        }
    }
}
