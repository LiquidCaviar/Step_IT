using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Abstraction.Models.TVShowsModels;
using MovieAPIPCL.Abstraction.Services;
using MovieAPIPCL.DTOs.TvShowsDTO;
using MovieAPIPCL.Implementation.Models;
using MovieAPIPCL.Implementation.Models.TVShowsModels;
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

        public async Task<ITVShowDetails> GetTVShowDetailsAsync(int TVShowID)
        {
            var TVShowDetails = await ApiHandler.GetApi<TVShowDetailsRootDTO>($"/tv/{TVShowID}?language=en-US&");

            return new TVShowDetails()
            {
                backdrop_path= ApiHandler.defaultImagePath + TVShowDetails.backdrop_path,
                created_by= TVShowDetails.created_by,
                episode_run_time= TVShowDetails.episode_run_time,
                first_air_date= TVShowDetails.first_air_date,
                genres= TVShowDetails.genres,
                homepage= TVShowDetails.homepage,
                id= TVShowDetails.id,
                in_production= TVShowDetails.in_production,
                languages= TVShowDetails.languages,
                last_air_date= TVShowDetails.last_air_date,
                last_episode_to_air= TVShowDetails.last_episode_to_air,
                name= TVShowDetails.name,
                networks= TVShowDetails.networks,
                next_episode_to_air= TVShowDetails.next_episode_to_air,
                number_of_episodes= TVShowDetails.number_of_episodes,
                number_of_seasons= TVShowDetails.number_of_seasons,
                original_language= TVShowDetails.original_language,
                original_name= TVShowDetails.original_name,
                origin_country= TVShowDetails.origin_country,
                overview= TVShowDetails.overview,
                popularity= TVShowDetails.popularity,
                poster_path= ApiHandler.defaultImagePath + TVShowDetails.poster_path,
                production_companies= TVShowDetails.production_companies,
                seasons= TVShowDetails.seasons,
                status= TVShowDetails.status,
                type= TVShowDetails.type,
                vote_average= TVShowDetails.vote_average*10,
                vote_count= TVShowDetails.vote_count,
            };
        }
    }
}
