using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models
{
    interface ITrendingMovie
    {
         int id { get; set; }
         bool video { get; set; }
         int vote_count { get; set; }
         double vote_average { get; set; }
         string title { get; set; }
         string release_date { get; set; }
         string original_language { get; set; }
         string original_title { get; set; }
         List<int> genre_ids { get; set; }
         string backdrop_path { get; set; }
         bool adult { get; set; }
         string overview { get; set; }
         string poster_path { get; set; }
         double popularity { get; set; }
         string media_type { get; set; }
         string original_name { get; set; }
         string name { get; set; }
         string first_air_date { get; set; }
         List<string> origin_country { get; set; }
    }
}
