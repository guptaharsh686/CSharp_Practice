using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Deligates
{
    public class PhotoProcessor
    {
        //public delegate void photoFilterHandler(Photo photo);
       //using pre defined generic delegates
       //Action returns void
       //Func can return any value
        
        public void Process(string path,Action<Photo> photoFilter)
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
