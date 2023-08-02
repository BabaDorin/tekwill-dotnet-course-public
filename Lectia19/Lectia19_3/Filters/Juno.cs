using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectia19_3.Filters
{
    internal class Juno : IFilter
    {
        public void Apply(Photo photo)
        {
            photo.Shadows += 2;
            photo.Brightness += 2;
            photo.Whites -= 35;
            photo.Exposure -= 143;
            photo.Contrast += 130;
        }
    }
}
