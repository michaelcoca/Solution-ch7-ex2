﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7_ex2
{
    interface IScaryClown:IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
