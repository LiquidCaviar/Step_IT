using MovieAPIPCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Implementation.Models
{
    public class FrontMediaModel : IFrontMediaModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string MediaTitle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rate { get; set; }

    }
}
