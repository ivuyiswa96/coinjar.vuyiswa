using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using jar.api.Interfaces;

using memory.cache.practice.helper;
using memory.cache.practice.Models;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;
using Coin = jar.api.Models.Coin;


namespace jar.api.Domain
{
    public class CoilJar :ICoinJar
    {
        
        public void AddCoin(ICoin coin)
        {
            if (Result.Amount + coin.Volume< CoinTypes.MAX_VOLUME)
            {
               Result.Amount = Result.Amount + coin.Amount;
               Result.Volume = Result.Volume + coin.Volume;
            }
            else throw new Exception("Coins exceed maximum volume");

        }

        public decimal GetTotalAmount()
        {
            return Result.Amount;
        }

        public void Reset()
        {
            Result.Amount = 0;
            Result.Volume = 0;
        }
    }
}
