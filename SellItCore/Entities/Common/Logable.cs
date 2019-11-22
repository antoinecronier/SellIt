using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellItCore.Entities.Common
{
    public interface Logable
    {
        String Login { get; set; }
        String Password { get; set; }
    }
}
