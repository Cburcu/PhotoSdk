using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFilterSDK
{
    public interface IResize
    {
        string ResizeName { get; set; }

        void ApplyResize();
    }
}
