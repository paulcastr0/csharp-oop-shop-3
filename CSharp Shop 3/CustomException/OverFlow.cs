using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_3.CustomException
{
    internal class OverFlow : Exception
    {
        internal OverFlow(string message) : base(message) 
        { }

    }
}
