using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_3.CustomException
{
    internal class ResultCannotBeNegative : Exception
    {
        internal ResultCannotBeNegative(string message) : base(message) 
        {
        }
    }
    
    
}
