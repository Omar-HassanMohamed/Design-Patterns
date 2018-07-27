using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy_Pattern
{
    public class FinalImage : Imager
    {
        public Image GetImage()
        {
            return new Image { MyProperty = 2 };
        }
    }
}
