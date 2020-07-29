using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models
{
    public interface IMovieActor
    {
         int Cast_id { get; set; }
         string Character { get; set; }
         string Credit_id { get; set; }
         int Gender { get; set; }
         int Id { get; set; }
         string Name { get; set; }
         int Order { get; set; }
         string Profile_path { get; set; }

    }
}
