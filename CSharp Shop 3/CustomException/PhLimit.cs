using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_3.CustomException
{
    internal class PhLimit : Exception
    {
        public string message;
        internal PhLimit(string message) : base(message) 
        {
            this.message = message;
        }
    }
   
  
}
