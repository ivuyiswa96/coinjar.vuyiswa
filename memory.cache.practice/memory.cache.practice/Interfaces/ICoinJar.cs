using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using memory.cache.practice.helper;

namespace jar.api.Interfaces
{
    public interface ICoinJar
    {
        void AddCoin(ICoin coin);
        
        decimal GetTotalAmount();
        void Reset();
    }
}
