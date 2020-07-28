using MovieAPIPCL.Abstraction.Models;
using MovieAPIPCL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Services
{
    public interface IActorService
    {
        Task<IEnumerable<IMovieActor>> GetMovieActors(int movieID);

        
    }
}
