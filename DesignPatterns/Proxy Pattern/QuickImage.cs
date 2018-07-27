﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy_Pattern
{
    public class QuickImage : Imager
    {
        public Image GetImage()
        {
            return new Image {MyProperty =1 } ;
        }
    }
}