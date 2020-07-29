using MovieAPIPCL.Abstraction.Services;
using MovieAPIPCL.Implementation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProject_V1._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ServiceContainer.CustomServiceContainer.AddAsSignleton<IMovieService, MovieService>(new MovieService());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());

            //edit stufffff
        }
    }
}
