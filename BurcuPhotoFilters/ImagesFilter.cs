using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurcuPhotoFilters
{
    public class ImagesFilter 
    {
        public Images PhotoFilter(Images photo, Filter filter)
        {
            photo.Filters.Add(filter.FilterName);
            return photo;
        }
    }
}
