using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jar.api.Interfaces
{
    public interface ICoin
    {
        decimal Amount { get; set; }
        decimal Volume { get; set; }
    }
}
