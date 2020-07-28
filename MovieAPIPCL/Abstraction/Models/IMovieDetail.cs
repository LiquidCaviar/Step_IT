using MovieAPIPCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models
{
    public interface IMovieDetail
    {
         bool Adult { get; set; } //+
        
         int Budget { get; set; } //+
         List<Genre> Genres { get; set; } //+
         
         int Id { get; set; } //+         
         string Original_language { get; set; } //+
         string Original_title { get; set; } //+
         string Overview { get; set; } //+
         double Popularity { get; set; }
         string Poster_path { get; set; } //+
         
         DateTime Release_date { get; set; } //+
         int Revenue { get; set; } //+
         int Runtime { get; set; }
         List<SpokenLanguage> Spoken_languages { get; set; }
         string Status { get; set; } //+
         string Tagline { get; set; }
         string Title { get; set; }         
         double Vote_average { get; set; } //+
         
    }
}
