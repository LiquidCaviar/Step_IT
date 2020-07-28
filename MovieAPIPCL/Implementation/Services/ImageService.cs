using MovieAPIPCL.Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Services
{
    public class ImageService : IImageService
    {
        private static string baseUrl = "https://image.tmdb.org/t/p/w500";
        public string GetFullImageURL(string posterPath)
        {
            string fullUrl = $"{baseUrl}{posterPath}";
            return fullUrl;
        }
    }
}
