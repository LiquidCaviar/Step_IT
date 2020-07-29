using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Abstraction.Services;
using MovieAPIPCL.DTOs.TvShowsDTO;
using MovieAPIPCL.Implementation.Models;
using MovieAPIPCL.WebAPIHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Services
{
    public class TvShowsService : ITvShowsService
    {
        public async Task<IEnumerable<IFrontMediaModel>> GetAiringTodayTVShowsPagenationAsync(int page = 1)
        {
            var AiringTVShows = await ApiHandler.GetApi<AiringTodayTVShowsRootDTO>($"/tv/airing_today?language=en-US&page={page}&");
            return AiringTVShows.results.Select(i => new FrontMediaModel()
            {
                Id=i.id,
                Image="https://image.tmdb.org/t/p/w500"+i.poster_path,
                MediaTitle=i.name,
                overview=i.overview,
                Rate=i.vote_average*10,
                ReleaseDate=i.first_air_date
            });
        }

        public async Task<IEnumerable<IFrontMediaModel>> GetOnTVShowsPagenationAsync(int page = 1)
        {
            var onTvShows = await ApiHandler.GetApi<OnTVShowsRootDTO>($"/tv/on_the_air?language=en-US&page={page}&");
            return onTvShows.results.Select(i => new FrontMediaModel()
            {
                Id=i.id,
                Image= "https://image.tmdb.org/t/p/w500"+i.poster_path,
                MediaTitle=i.name,
                overview=i.overview,
                Rate=i.vote_average*10,
                ReleaseDate=i.first_air_date
            });
        }

        public async Task<IEnumerable<IFrontMediaModel>> GetPopularTVShowsPagenationAsync(int page = 1)
        {
            var popularTVShows = await ApiHandler.GetApi<PopularTVShowsRootDTO>($"/tv/popular?language=en-US&page={page}&");
            return popularTVShows.results.Select(i => new FrontMediaModel()
            {
                Id=i.id,
                Image= "https://image.tmdb.org/t/p/w500"+i.poster_path,
                MediaTitle=i.name,
                Rate=i.vote_average*10,
                overview=i.overview,
                ReleaseDate=i.first_air_date
            });
        }


        public async Task<IEnumerable<IFrontMediaModel>> GetTopRatedTVShowsPagenationAsync(int page = 1)
        {
            var topRatedShows = await ApiHandler.GetApi<TopRatedTVShowsRootDTO>($"/tv/top_rated?language=en-US&page={page}&");
            return topRatedShows.results.Select(i => new FrontMediaModel()
            {
                Id = i.id,
                Image = "https://image.tmdb.org/t/p/w500" + i.poster_path,
                MediaTitle = i.name,
                Rate = i.vote_average * 10,
                overview = i.overview,
                ReleaseDate = i.first_air_date
            });
        }



    }
}
