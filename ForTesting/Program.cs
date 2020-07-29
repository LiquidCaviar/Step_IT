using MovieAPIPCL.Implementation.Services;
using System;
using System.Threading.Tasks;

namespace ForTesting
{
    class Program
    {
        static async Task Main(string[] args)
        {
            MovieService ms = new MovieService();
            var test = await ms.GetPopularMoviesPagenationAsync();
            var movieDetail = await ms.GetMovieDetailAsync(516486);

            ActorService actorS = new ActorService();
            var testAs = await actorS.GetMovieActorDetail(85);

            MultiSearchService msServ = new MultiSearchService();
            var testMser = await msServ.MultiSearch("The Flash");

            TvShowsService tvSer = new TvShowsService();
            var tvPop = await tvSer.GetAiringTodayTVShowsPagenationAsync();
            
            Console.WriteLine();
        }
    }
}
