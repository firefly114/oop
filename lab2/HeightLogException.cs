﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class HeightLogException : Exception
    {
        public int LogLength;
        public HeightLogException(string message, int logLength)
            : base (message)
        {
            this.LogLength = logLength;
        }
    }
}