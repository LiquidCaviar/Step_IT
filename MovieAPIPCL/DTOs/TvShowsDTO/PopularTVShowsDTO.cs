﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.DTOs.TvShowsDTO
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class PopularTVShowDTO
    {
        public string original_name { get; set; }
        public List<int> genre_ids { get; set; }
        public string name { get; set; }
        public double popularity { get; set; }
        public List<string> origin_country { get; set; }
        public int vote_count { get; set; }
        public string first_air_date { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public int id { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }

    }

    public class PopularTVShowsRootDTO
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<PopularTVShowDTO> results { get; set; }

    }


}
