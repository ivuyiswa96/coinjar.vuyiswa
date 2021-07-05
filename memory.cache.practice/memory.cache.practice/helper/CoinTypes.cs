using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Coin = jar.api.Models.Coin;

namespace memory.cache.practice.helper
{
    
       public static class CoinTypes
        {
      
            public static readonly int MAX_VOLUME = 32;

            public enum CoinType
            {
                ONE_CENT ,
                FIVE_CENT,
                TEN_CENT,
                TWENTY_FIVE_CENT
            }

        public static  List<jar.api.Models.Coin> Coins = new List<jar.api.Models.Coin>()
            {
                new jar.api.Models.Coin(){Amount = 1,Volume = 5},
                new jar.api.Models.Coin(){Amount = 5,Volume = 6},
                new jar.api.Models.Coin(){Amount = 10,Volume = 3},
                new jar.api.Models.Coin(){Amount = 25,Volume = 8}
              

            };
        }

    }

