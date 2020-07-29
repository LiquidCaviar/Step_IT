using MovieAPIPCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models
{
    public interface IPerson
    {
        string name { get; set; }
         string known_for_department { get; set; }
         string poster_path { get; set; }
         List<MultiSearchKnownFor> knownFor { get; set; }


    }

   
}
