using MovieAPIPCL.DTOs.MovieDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models.MovieModels
{
    public interface IMovieImages
    {
         List<MovieImagesBackdrop> backdrops { get; set; }
         List<MovieImagesPoster> posters { get; set; }
    }
}
