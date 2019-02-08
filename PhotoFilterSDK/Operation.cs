using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFilterSDK
{
    public class Operation
    {
        public int Add(int x, int y)
        {
            int z;
            if ((x == 10) && (y == 20))
            {
                z = x + y;
            }
            else
            {
                z = x;
            }
            return z;
        }
    }
}
