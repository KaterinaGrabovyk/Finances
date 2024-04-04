using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    internal class Class1
    {
        private static Class1 instance;
        public static Class1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Class1();
                }
                return instance;
            }
        }
        public void Add()
        {

        }
    }
}
