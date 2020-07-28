using MovieAPIPCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models
{
    public class MovieActorDetail : IMovieActorDetail
    {
        public string Birthday { get; set; }
        public string Known_for_department { get; set; }
        public object Deathday { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Also_known_as { get; set; }
        public int Gender { get; set; }
        public string Biography { get; set; }
        public double Popularity { get; set; }
        public string Place_of_birth { get; set; }
        public string Profile_path { get; set; }
        public bool Adult { get; set; }
        public string Imdb_id { get; set; }
        public object Homepage { get; set; }
    }
}
