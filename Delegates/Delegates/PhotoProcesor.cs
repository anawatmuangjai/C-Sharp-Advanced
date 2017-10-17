using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        // Example 3: use Action<>
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

        // Example 2: user delegate keyword
        //public delegate void PhotoFilterHandler(Photo photo);

        //public void Process(string path, PhotoFilterHandler filterHandler)
        //{
        //    var photo = Photo.Load(path);

        //    filterHandler(photo);

        //    photo.Save();
        //}

        // Example 1
        //public void Process(string path)
        //{
        //    var photo = Photo.Load(path);

        //    var filters = new PhotoFilters();
        //    filters.ApplyBrightness(photo);
        //    filters.ApplyContrast(photo);
        //    filters.Resize(photo);

        //    photo.Save();
        //}
    }
}
