using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoFilterSDK;

namespace BurcuPhotoFilters
{
    public class Filter : IFilter
    {
        public string FilterName { get; set; }

        public void ApplyFilter()
        {
            Console.WriteLine("{0} filtresi uygulandı.", FilterName);
        }
    }
}
