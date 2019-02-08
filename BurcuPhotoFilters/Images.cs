using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoFilterSDK;

namespace BurcuPhotoFilters
{
    public class Images : IImage
    {
        public string Name { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public List<string> Filters { get; set; }
    }
}
