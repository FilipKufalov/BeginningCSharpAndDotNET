using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10._1Exercise
{
    public class myDerivedClass : myClass
    {
        public override string GetString()
        {
            return myString + "(output from derived class)";
        }
    }
}