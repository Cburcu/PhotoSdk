using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoFilterSDK;

namespace BurcuPhotoFilters
{
    public class Resize : IResize
    {
        public string ResizeName { get; set; }
        public void ApplyResize()
        {
            Console.WriteLine("Yeniden boyutlandırıldı.");
        }
    }
}
