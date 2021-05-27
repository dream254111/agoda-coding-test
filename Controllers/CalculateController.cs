using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgodaTest.Models;

namespace AgodaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetGCDFromArray([FromBody] NumberRequestDTO intDTO)
        {
            var array = intDTO.Numbers;
            var pointer = array.Length;

            while (pointer > 1)
            {
                array[pointer - 2] = FindGCD(array[pointer - 2], array[pointer - 1]);
                pointer--;
            }

            NumberResponseDTO response = new NumberResponseDTO
            {
                GCD = array[0]
            };

            return Ok(response);
        }

        public int FindGCD(int num1, int num2)
        {
            if (num2 == 0)
                return num1;
            else if (num1 > num2)
                return FindGCD(num2, num1 % num2);
            else
                return FindGCD(num1, num2 % num1);
        }
    }
}
