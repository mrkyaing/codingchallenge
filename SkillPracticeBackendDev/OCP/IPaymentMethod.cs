﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillPracticeBackendDev.OCP
{
    public interface IPaymentMethod
    {
        void ProcessPayment();
    }
}