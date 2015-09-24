﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    interface ICarFactory
    {
        string ProgrammerName { get; }
        ICar CreateCar(string name);
    }
}
