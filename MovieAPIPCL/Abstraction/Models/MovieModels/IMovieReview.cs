using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models.MovieModels
{
    public interface IMovieReview
    {
         string author { get; set; }
         string content { get; set; }
         string id { get; set; }
         string url { get; set; }
    }
}
