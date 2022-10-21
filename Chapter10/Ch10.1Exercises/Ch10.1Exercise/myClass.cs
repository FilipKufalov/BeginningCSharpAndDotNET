using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10._1Exercise
{
    public class myClass
    {
        protected string myString;

        public string ContainedString { set { myString = value; }}

        public virtual string GetString()
        {
            return myString;
        }
    }
}