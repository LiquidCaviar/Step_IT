using MovieAPIPCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models
{
    public class MovieActor : IMovieActor
    {
        public int Cast_id { get; set; }
        public string Character { get; set; }
        public string Credit_id { get; set; }
        public int Gender { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string Profile_path { get; set; }
    }
}
