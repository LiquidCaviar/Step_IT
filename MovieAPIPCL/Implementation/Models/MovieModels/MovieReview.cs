using MovieAPIPCL.Abstraction.Models.MovieModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models.MovieModels
{
    public class MovieReview : IMovieReview
    {
        public string author { get; set; }
        public string content { get; set; }
        public string id { get; set; }
        public string url { get; set; }
    }
}
