using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.DTOs.MovieDTO
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class MovieCommentsDTO
    {
        public string author { get; set; }
        public string content { get; set; }
        public string id { get; set; }
        public string url { get; set; }

    }

    public class MovieCommentsRootDTO
    {
        public int id { get; set; }
        public int page { get; set; }
        public List<MovieCommentsDTO> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }

    }


}
