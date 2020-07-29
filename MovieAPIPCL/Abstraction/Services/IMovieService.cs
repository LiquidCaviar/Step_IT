using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Abstraction.Models.MovieModels;
using MovieAPIPCL.DTOs;
using MovieAPIPCL.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<IFrontMediaModel>> GetPopularMoviesPagenationAsync(int page=1);
        Task<IEnumerable<IFrontMediaModel>> GetTrendingMoviesAsync(string timeWindow);// timeWindow= "day" or "week"

        Task<IEnumerable<IFrontMediaModel>> GetNowPlayingMoviesPagenationAsync(int page = 1);

        Task<IMovieDetail> GetMovieDetailAsync(int movieID);

        Task<IEnumerable<IFrontMediaModel>> GetTopRatedMoviesPagenationAsync(int page = 1);

        Task<IEnumerable<IFrontMediaModel>> GetUpcomingMoviesPagenationAsync(int page = 1);

        Task<string> GetMovieTrailerURLByID(int movieID);

        Task<List<FrontMediaModel>> GetMovieRecommendations(int movieID);

        Task<IEnumerable<IMovieReview>> GetMovieReviews(int movieID);

        Task<IMovieImages> GetMovieImagesAsync(int movieID);
    }
}
