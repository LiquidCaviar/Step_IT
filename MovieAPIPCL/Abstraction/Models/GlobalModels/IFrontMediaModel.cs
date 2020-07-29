using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.Abstraction.Models
{
    public interface IFrontMediaModel
    {
         int? Id { get; set; }
         string Image { get; set; }
         string MediaTitle { get; set; }
         DateTime? ReleaseDate { get; set; }
         double? Rate { get; set; }
         string overview { get; set; }
         
    }
}
