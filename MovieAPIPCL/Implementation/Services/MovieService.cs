using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Abstraction.Services;
using MovieAPIPCL.DTOs;
using MovieAPIPCL.Implementation.Models;
using MovieAPIPCL.WebAPIHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieAPIPCL.Implementation.Services
{
    public class MovieService : IMovieService
    {
        public async Task<IEnumerable<IFrontMediaModel>> GetPopularMoviesPagenationAsync(int page=1)
        {
            var popularMovies = await ApiHandler.GetApi<PopularMovieRootDTO>($"/movie/popular?language=en-US&page={page}&");

            var result=popularMovies.results
                ?.Select(i => new FrontMediaModel()
                {

                    Id=i.id,
                    MediaTitle=i.title,
                    Image=i.poster_path,
                    ReleaseDate=i.release_date,
                    Rate=i.vote_average*10
                    
                });
                
            return result;
        }

        public async Task<IEnumerable<IFrontMediaModel>> GetTrendingMoviesAsync(string timeWindow) // timeWindow: "day" or "week"
        {
            var trendingMovies = await ApiHandler.GetApi<TrendingMovieRootDTO>($"/trending/all/{timeWindow}?");

            var result = trendingMovies.results
                ?.Select(i => new FrontMediaModel()
                {
                    Id = i.id,
                    MediaTitle = i.title,
                    Image = i.poster_path,
                    ReleaseDate = i.release_date,
                    Rate = i.vote_average * 10                   

                });

            return result;
        }

        public async Task<IEnumerable<IFrontMediaModel>> GetNowPlayingMoviesPagenationAsync(int page=1) // timeWindow: "day" or "week"
        {
            var nowPlayingMovies = await ApiHandler.GetApi<NowPlayingMoviesRootDTO>($"/movie/now_playing?language=en-US&page={page}&");

            var result = nowPlayingMovies.results
                ?.Select(i => new FrontMediaModel()
                {
                    Id = i.id,
                    MediaTitle = i.title,
                    Image = i.poster_path,
                    ReleaseDate = i.release_date,
                    Rate = i.vote_average * 10

                });

            return result;
        }

        public async Task<IMovieDetail> GetMovieDetailAsync(int movieID)
        {
            var movieDetail = await ApiHandler.GetApi<MovieDetailsRootDTO>($"/movie/{movieID}?language=en-US&");

            var result = new MovieDetail()
            {
                Adult = movieDetail.adult,
                Budget= movieDetail.budget,
                Genres= movieDetail.genres,
                Id= movieDetail.id,
                Original_language= movieDetail.original_language,
                Original_title= movieDetail.original_title,
                Overview= movieDetail.overview,
                Popularity= movieDetail.popularity,
                Poster_path= movieDetail.poster_path,
                Release_date= movieDetail.release_date,
                Revenue= movieDetail.revenue,
                Runtime= movieDetail.runtime,
                Spoken_languages= movieDetail.spoken_languages,
                Status= movieDetail.status,
                Tagline= movieDetail.tagline,
                Title= movieDetail.title,
                Vote_average= movieDetail.vote_average

            };

            return result;
        }

        public async Task<IEnumerable<IFrontMediaModel>> GetTopRatedMoviesPagenationAsync(int page = 1)
        {
            var topRatedMovies = await ApiHandler.GetApi<TopRatedMoviesDTO>($"/movie/top_rated?language=en-US&page={page}&");

            var result = topRatedMovies.results
                ?.Select(i => new FrontMediaModel()
                {
                    Id=i.id,
                    Image=i.poster_path,
                    MediaTitle=i.title,
                    Rate=i.vote_average,
                    ReleaseDate=i.release_date                    

                });

            return result;
        }


    }
}
