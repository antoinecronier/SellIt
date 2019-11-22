using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellItCore.Entities.Common
{
    public interface DbEntity
    {
        long Id { get; set; }
    }
}
