using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Services
{
    public class TvShowsService : ITvShowsService
    {
        public Task<IFrontMediaModel> GetPopularTVShowsPagenationAsync(int page = 1)
        {
            return default;
        }
    }
}
