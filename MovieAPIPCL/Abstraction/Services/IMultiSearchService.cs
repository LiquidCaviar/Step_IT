using MovieAPIPCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Services
{
    public interface IMultiSearchService
    {
        Task<IMultiSearchData> MultiSearch(string query);
    }
}
