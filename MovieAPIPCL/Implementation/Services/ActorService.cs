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
    public class ActorService : IActorService
    {
        

        public async Task<IEnumerable<IMovieActor>> GetMovieActors(int movieID)
        {
            var movieActors = await ApiHandler.GetApi<MovieActorRootDTO>($"/movie/{movieID}/credits?");

            var movieCast = movieActors.cast.Select(i => new MovieActor()
            {
                Cast_id=i.cast_id,
                Character=i.character,
                Credit_id=i.credit_id,
                Gender=i.gender,
                Id=i.id,
                Name=i.name,
                Order=i.order,
                Profile_path= "https://image.tmdb.org/t/p/w500"+i.profile_path
            });

            return movieCast;
        }


        public async Task<IMovieActorDetail> GetMovieActorDetail(int actorId)
        {
            var movieActorDetail = await ApiHandler.GetApi<MovieActorDetailDTO>($"/person/{actorId}?language=en-US&");



            return new MovieActorDetail()
            {
                Profile_path= "https://image.tmdb.org/t/p/w500" + movieActorDetail.profile_path,
                Adult= movieActorDetail.adult,
                Also_known_as= movieActorDetail.also_known_as,
                Biography= movieActorDetail.biography,
                Birthday= movieActorDetail.birthday,
                Deathday= movieActorDetail.deathday,
                Gender= movieActorDetail.gender,
                Homepage= movieActorDetail.homepage,
                Id= movieActorDetail.id,
                Imdb_id= movieActorDetail.imdb_id,
                Known_for_department= movieActorDetail.known_for_department,
                Name= movieActorDetail.name,
                Place_of_birth= movieActorDetail.place_of_birth,
                Popularity= movieActorDetail.popularity
            };
        }

    }
}
