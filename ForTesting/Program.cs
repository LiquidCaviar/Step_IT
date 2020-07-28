using MovieAPIPCL.Implementation.Services;
using System;
using System.Threading.Tasks;

namespace ForTesting
{
    class Program
    {
        static async Task Main(string[] args)
        {
            MovieService ms = new MovieService();
            var test = await ms.GetUpcomingMoviesPagenationAsync();

            Console.WriteLine();
        }
    }
}
