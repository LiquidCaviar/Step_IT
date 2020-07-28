using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models
{
    public interface IMovieActorDetail
    {
         string Birthday { get; set; }
         string Known_for_department { get; set; }
         object Deathday { get; set; }
         int Id { get; set; }
         string Name { get; set; }
         List<string> Also_known_as { get; set; }
         int Gender { get; set; }
         string Biography { get; set; }
         double Popularity { get; set; }
         string Place_of_birth { get; set; }
         string Profile_path { get; set; }
         bool Adult { get; set; }
         string Imdb_id { get; set; }
         object Homepage { get; set; }

    }
}
