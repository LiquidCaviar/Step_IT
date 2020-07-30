using MovieAPIPCL.DTOs.TvShowsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models.TVShowsModels
{
    public interface ITVShowDetails
    {
         string backdrop_path { get; set; }
         List<CreatedBy> created_by { get; set; }
         List<int> episode_run_time { get; set; }
         string first_air_date { get; set; }
         List<Genre> genres { get; set; }
         string homepage { get; set; }
         int id { get; set; }
         bool in_production { get; set; }
         List<string> languages { get; set; }
         string last_air_date { get; set; }
         LastEpisodeToAir last_episode_to_air { get; set; }
         string name { get; set; }
         object next_episode_to_air { get; set; }
         List<Network> networks { get; set; }
         int number_of_episodes { get; set; }
         int number_of_seasons { get; set; }
         List<string> origin_country { get; set; }
         string original_language { get; set; }
         string original_name { get; set; }
         string overview { get; set; }
         double popularity { get; set; }
         string poster_path { get; set; }
         List<ProductionCompany> production_companies { get; set; }
         List<Season> seasons { get; set; }
         string status { get; set; }
         string type { get; set; }
         double vote_average { get; set; }
         int vote_count { get; set; }
    }
}
