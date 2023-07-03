using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Deligates
{
    public class PhotoProcessor
    {
        public delegate void photoFilterHandler(Photo photo);
        public void Process(string path,photoFilterHandler photoFilter)
        {
            var photo = Photo.Load(path);

            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            photoFilter(photo);

            photo.Save();
        }
    }
}
