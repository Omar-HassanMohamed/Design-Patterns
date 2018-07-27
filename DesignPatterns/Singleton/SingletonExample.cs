using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class SingletonExample
    {
        private static SingletonExample uniqueInstance = null;
        private static object obj = new object();
        private SingletonExample()
        {

        }
        public static SingletonExample GetInstance()
        {
            lock (obj)
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new SingletonExample();
                }
                return uniqueInstance;
            }
        }
    }
}
