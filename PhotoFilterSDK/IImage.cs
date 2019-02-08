using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFilterSDK
{
    public interface IImage
    {
        string Name { get; set; }
        int SizeX { get; set; }
        int SizeY { get; set; }
        List<string> Filters { get; set; }
    }
}
