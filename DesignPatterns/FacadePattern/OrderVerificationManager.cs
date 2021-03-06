﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern
{
    public class OrderVerificationManager:IOrderVerify
    {
        public bool VerifyShippingAddress(int pincode)
        {
            Console.WriteLine(string.Format("The product can be shipped to the pincode {0}.",
                                             pincode));
            return true;
        }
    }
}
