﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Managers:Employees
    {
        public override void PrintName()
        {
            Console.WriteLine($"{name}");
        }
        public override void PrintDepartment()
        {
            Console.WriteLine($"{department="Manager"}");
        }
    }
}
