﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal interface IOrder
    {
        event EventHandler OrderReceived;
    }
}
