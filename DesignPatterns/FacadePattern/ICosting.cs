﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern
{
    interface ICosting
    {
        float ApplyDiscounts(float price, float discountPercent);
    }
}
