﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_3.CustomException
{
    internal class EmptyBottle : Exception
    {
        public string message;
        internal EmptyBottle(string message) : base(message)
        {
            this.message = message;
        }
    }
}
