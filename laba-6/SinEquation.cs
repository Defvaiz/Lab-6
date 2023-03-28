﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    public  class SinEquation : Equation
    {
        public readonly double a;
        public SinEquation(double a)
        {
            this.a = a;
        }
        public override double GetValue(double x)
        {
            return Math.Sin(a * x) / x;
        }
    }
}   
