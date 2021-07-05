using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jar.api.Interfaces;
using memory.cache.practice.helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;


namespace Jar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JarController : ControllerBase
    {
        private readonly ICoinJar _coinJar;

        public JarController(ICoinJar coinJar )
        {

            _coinJar = coinJar;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results = _coinJar.GetTotalAmount();
                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
  
        }
        [HttpPost]
        public IActionResult Post(CoinTypes.CoinType _coin)
        {
         
            try
            {
                var coin = CoinTypes.Coins[(int) _coin];
                if (ModelState.IsValid)
                {
                        _coinJar.AddCoin(coin);
                    return Ok("Successful added coin");
                }
                return BadRequest("Invalid inputs");

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        

        
        [HttpDelete("reset")]
        public IActionResult Reset()
        {
            try
            {
                _coinJar.Reset();
                return Ok("Successful reset ");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
