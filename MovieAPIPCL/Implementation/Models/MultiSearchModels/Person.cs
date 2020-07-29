using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models
{
    public class Person : IPerson
    {
        public string known_for_department { get; set; }
        public string poster_path { get; set; }
        public List<MultiSearchKnownFor> knownFor { get; set; } = new List<MultiSearchKnownFor>();
        public string name { get; set; }
    }
}
