﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UARTLogger
{
    public enum UARTStates
    {
        ReadingESP,
        WritingESP,
        ReadingPi,
        WritingPi
    }
}