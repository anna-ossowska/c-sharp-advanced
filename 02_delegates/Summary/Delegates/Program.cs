
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // Multicast delegate holds the reference to more than one method
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            // Getting all the methods assigned to the delegate 
            var delegMethods = filterHandler.GetInvocationList();

            foreach (var item in delegMethods)
            {
                Console.WriteLine(item.Method);
            }
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
