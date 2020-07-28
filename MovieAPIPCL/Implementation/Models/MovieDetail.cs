﻿using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models
{
    public class MovieDetail : IMovieDetail
    {
        public bool Adult { get; set; }
        public int Budget { get; set; }
        public List<Genre> Genres { get; set; }
        public int Id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string Poster_path { get; set; }
        public DateTime Release_date { get; set; }
        public int Revenue { get; set; }
        public int Runtime { get; set; }
        public List<SpokenLanguage> Spoken_languages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public double Vote_average { get; set; }
    }
}
