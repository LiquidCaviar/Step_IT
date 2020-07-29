using MovieAPIPCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Services
{
    public interface ITvShowsService
    {
        Task<IFrontMediaModel> GetPopularTVShowsPagenationAsync(int page=1);
    }
}
