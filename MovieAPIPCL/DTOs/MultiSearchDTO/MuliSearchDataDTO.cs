﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.DTOs
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class MultiSearchKnownFor
    {
        public string poster_path { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public string media_type { get; set; }
        public int id { get; set; }
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }

    }

    public class Result
    {
        public string original_name { get; set; }
        public int id { get; set; }
        public string media_type { get; set; }
        public string name { get; set; }
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public double vote_average { get; set; }
        public DateTime first_air_date { get; set; }
        public string poster_path { get; set; }
        public List<int> genre_ids { get; set; }
        public string original_language { get; set; }
        public string backdrop_path { get; set; }
        public string overview { get; set; }
        public List<string> origin_country { get; set; }
        public bool? video { get; set; }
        public bool? adult { get; set; }
        public string original_title { get; set; }
        public string title { get; set; }
        public DateTime release_date { get; set; }
        public string known_for_department { get; set; }
        public List<MultiSearchKnownFor> known_for { get; set; }
        public string profile_path { get; set; }
        public int? gender { get; set; }

    }

    public class MultiSearchRootDTO
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<Result> results { get; set; }

    }




}
