using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Abstraction.Models.MovieModels;
using MovieAPIPCL.Abstraction.Services;
using MovieAPIPCL.DTOs;
using MovieAPIPCL.DTOs.MovieDTO;
using MovieAPIPCL.Implementation.Models;
using MovieAPIPCL.Implementation.Models.MovieModels;
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
                    Image= "https://image.tmdb.org/t/p/w500" + i.poster_path,
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
                    Image = "https://image.tmdb.org/t/p/w500" + i.poster_path,
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
                    Image = "https://image.tmdb.org/t/p/w500" + i.poster_path,
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
                Budget = movieDetail.budget,
                Genres = movieDetail.genres,
                Id = movieDetail.id,
                Original_language = movieDetail.original_language,
                Original_title = movieDetail.original_title,
                Overview = movieDetail.overview,
                Popularity = movieDetail.popularity,
                Poster_path = "https://image.tmdb.org/t/p/w500" + movieDetail.poster_path,
                Release_date = movieDetail.release_date,
                Revenue = movieDetail.revenue,
                Runtime = movieDetail.runtime,
                Spoken_languages = movieDetail.spoken_languages,
                Status = movieDetail.status,
                Tagline = movieDetail.tagline,
                Title = movieDetail.title,
                Vote_average = movieDetail.vote_average * 10,
                movieTrailerURL = await GetMovieTrailerURLByID(movieDetail.id),
                videoUrls = await GetMovieVideosURLByID(movieDetail.id),
                RecommendedMovies = await GetMovieRecommendations(movieDetail.id),
                movieReviews=(await GetMovieReviews(movieDetail.id))?.ToList(),
                movieImages=(MovieImages)await GetMovieImagesAsync(movieDetail.id)

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
                    Image= "https://image.tmdb.org/t/p/w500" + i.poster_path,
                    MediaTitle=i.title,
                    Rate=i.vote_average*10,
                    ReleaseDate=i.release_date                    

                });

            return result;
        }


        public async Task<IEnumerable<IFrontMediaModel>> GetUpcomingMoviesPagenationAsync(int page = 1)
        {
            var upcomingMovies = await ApiHandler.GetApi<UpcomingMoviesRootDTO>($"/movie/upcoming?language=en-US&page={page}&");

            var result = upcomingMovies.results
                ?.Select(i => new FrontMediaModel()
                {
                    Id = i.id,
                    Image = "https://image.tmdb.org/t/p/w500" + i.poster_path,
                    MediaTitle = i.title,
                    Rate = i.vote_average*10,
                    ReleaseDate = i.release_date

                });

            return result;
        }

        public async Task<string> GetMovieTrailerURLByID(int movieID)
        {
            var movieVideos = await ApiHandler.GetApi<MovieVideosRootDTO>($"/movie/{movieID}/videos?language=en-US&");
            string key = movieVideos.results.FirstOrDefault(i => i.type == "Trailer").key;
            return $"https://www.youtube.com/watch?v={key}";
             
        }

        public async Task<List<string>> GetMovieVideosURLByID(int movieID)
        {
            var movieVideos = await ApiHandler.GetApi<MovieVideosRootDTO>($"/movie/{movieID}/videos?language=en-US&");
            string key = movieVideos.results.FirstOrDefault(i => i.type == "Trailer").key;
            return movieVideos.results.Select(i => $"https://www.youtube.com/watch?v={i.key}").ToList();           

        }

        public async Task<List<FrontMediaModel>> GetMovieRecommendations(int movieID) // ??????????????????????????????  IEnumerable<IFrontMediaModel>
        {
            var recommendations = await ApiHandler.GetApi<MovieRecommendationsRootDTO>($"/movie/{movieID}/recommendations?language=en-US&page=1&");
            return recommendations.results.Select(i => new FrontMediaModel()
            {
                Id=i.id,
                Image=i.poster_path,
                MediaTitle=i.title,
                overview=i.overview,
                Rate=i.vote_average*10,
                ReleaseDate=i.release_date
                
            }).ToList();
             
        }

        public async Task<IEnumerable<IMovieReview>> GetMovieReviews(int movieID)
        {
            var reviews = await ApiHandler.GetApi<MovieCommentsRootDTO>($"/movie/{movieID}/reviews?language=en-US&page=1&");
            return reviews.results.Select(i => new MovieReview()
            { 
                author=i.author,
                content=i.content,
                id=i.id,
                url=i.url
            });

        }

        public async Task<IMovieImages> GetMovieImagesAsync(int movieID)
        {
            var movieImages = await ApiHandler.GetApi<MovieImagesRootDTO>($"/movie/{movieID}/images?");
            var movieBackdrops = movieImages.backdrops.Select(i => new MovieImagesBackdrop()
            {
                aspect_ratio=i.aspect_ratio,
                file_path= "https://image.tmdb.org/t/p/w500"+i.file_path,
                height=i.height,
                iso_639_1=i.iso_639_1,
                vote_average=i.vote_average*10,
                vote_count=i.vote_count,
                width=i.width
            }).ToList();
            var moviePosters = movieImages.posters.Select(i => new MovieImagesPoster()
            {
                aspect_ratio = i.aspect_ratio,
                file_path = "https://image.tmdb.org/t/p/w500" + i.file_path,
                height = i.height,
                iso_639_1 = i.iso_639_1,
                vote_average = i.vote_average * 10,
                vote_count = i.vote_count,
                width = i.width
            }).ToList();


            return new MovieImages() { backdrops = movieBackdrops, posters = moviePosters };

        }

        

    }
}
