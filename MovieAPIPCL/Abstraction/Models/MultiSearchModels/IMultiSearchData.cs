using MovieAPIPCL.DTOs;
using MovieAPIPCL.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models
{
    public interface IMultiSearchData
    {
        
        List<FrontMediaModel> movies{get;set;}
        List<FrontMediaModel> tvShows { get; set; }
        List<Person> persons { get; set; }
    }
}
