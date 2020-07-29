using MovieAPIPCL.Abstraction.Models.MovieModels;
using MovieAPIPCL.DTOs.MovieDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models.MovieModels
{
    public class MovieImages : IMovieImages
    {
        public List<MovieImagesBackdrop> backdrops { get; set; }
        public List<MovieImagesPoster> posters { get; set; }
    }
}
