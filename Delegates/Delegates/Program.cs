using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //var procesor = new PhotoProcesor();
            //procesor.Process("Test.jpg");

            var procesor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            procesor.Process("Test.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply Remove RedEye");
        }
    }
}
