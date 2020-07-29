using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models
{
    public class MultiSearchData : IMultiSearchData
    {
        public List<FrontMediaModel> movies { get; set; } = new List<FrontMediaModel>();
        public List<FrontMediaModel> tvShows { get; set; } = new List<FrontMediaModel>();
        public List<Person> persons { get; set; } = new List<Person>();
    }
}
