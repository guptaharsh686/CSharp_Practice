using System;

namespace CSharp_Deligates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var photopro = new PhotoProcessor();
            var filters = new PhotoFilters();
            var photo = new Photo();

            PhotoProcessor.photoFilterHandler photoFilterHandler = filters.ApplyBrightness;
            photoFilterHandler += filters.ApplyContrast;
            photoFilterHandler += AddRedEye;

            photopro.Process("afawfa",photoFilterHandler);
        }

        public static void AddRedEye(Photo photo)
        {
            Console.WriteLine("Applying Red Eye filter");
        }
    }
}
