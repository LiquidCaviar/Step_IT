using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Abstraction.Services;
using MovieAPIPCL.DTOs;
using MovieAPIPCL.Implementation.Models;
using MovieAPIPCL.WebAPIHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Services
{
    public class MultiSearchService : IMultiSearchService
    {
        public async Task<IMultiSearchData> MultiSearch(string searchObject)
        {
            var searchResult = await ApiHandler.GetApi<MultiSearchRootDTO>($"/search/multi?language=en-US&query={searchObject}&page=1&include_adult=false&");
            var multiSearchData = new MultiSearchData();

            multiSearchData.movies.AddRange(searchResult.results.Where(i => i.media_type == "movie").Select(i => new FrontMediaModel()
            {
                Id=i.id,
                Image= "https://image.tmdb.org/t/p/w500" + i.poster_path,
                MediaTitle=i.title,
                Rate=i.vote_average*10,
                ReleaseDate=i.release_date,
                overview=i.overview
               
            }));

            multiSearchData.tvShows.AddRange(searchResult.results.Where(i => i.media_type == "tv").Select(i => new FrontMediaModel()
            {
                Id = i.id,
                Image = "https://image.tmdb.org/t/p/w500" + i.poster_path,
                MediaTitle = i.name,
                Rate = i.vote_average * 10,
                ReleaseDate = i.first_air_date,
                overview = i.overview
                
            }));

            multiSearchData.persons.AddRange(searchResult.results.Where(i => i.media_type == "person").Select(i => new Person()
            {
                name=i.name,
                knownFor=i.known_for,
                known_for_department=i.known_for_department,
                poster_path= "https://image.tmdb.org/t/p/w500" + i.profile_path
            }));

            return multiSearchData;

        }
    }
}
