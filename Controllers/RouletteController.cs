
using Derivco_Roulette.Data;
using Derivco_Roulette.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Derivco_Roulette.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouletteController : ControllerBase
    {


        private RouletteContext _rouletteContext;

        public RouletteController(RouletteContext rouletteContext)
        {
            _rouletteContext = rouletteContext;
        }

        // GET: api/<RouletteController>
        [HttpGet("Spin")]
        public async Task<WinningNumber> Get()
        {
            Random random = new Random();
            int WinningNumberIndex = random.Next(36);

            var x = Wheel.WheelNumbers[WinningNumberIndex];

            WinningNumber winningNumber = new WinningNumber() {
            
                Number = x.Number,
                Color = x.Colour.ToString()
            };


            _rouletteContext.WinningNumbers.Add(winningNumber);
           await _rouletteContext.SaveChangesAsync();



            return winningNumber;
        }

        // GET api/<RouletteController>/5
        [HttpGet("Payout")]
        public async Task<int> GetPayout()
        {
            var bet =  _rouletteContext.Bets.OrderByDescending(p => p.Id).FirstOrDefault();
            var winningNum = _rouletteContext.WinningNumbers.OrderByDescending(p => p.Id).FirstOrDefault();

            var odds = 1;
            var payout = 0;

            switch (bet.Type)
            {
                case "RED":
                    odds = 1;
                    if (winningNum.Color == bet.Type)
                    {
                        payout = bet.Amount * odds;
                    }
                    break;
                case "BLACK":
                    odds = 1;
                    if (winningNum.Color == bet.Type)
                    {
                        payout = bet.Amount * odds;
                    }
                    break;
                case "ODD":
                    odds = 1;

                    if (winningNum.Number % 2 != 0)
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "EVEN":
                    odds = 1;

                    if (winningNum.Number % 2 == 0)
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "HIGH":
                    odds = 1;

                    if (winningNum.Number>=19 && winningNum.Number <= 36)
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "LOW":
                    odds = 1;
                    if (winningNum.Number >= 1 && winningNum.Number <= 18)
                    {
                        payout = bet.Amount * odds;
                    }
                    break;
                case "COLUMN1":
                    odds = 2;

                    var list = new List<int> { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
                    if (list.Contains(winningNum.Number))
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "COLUMN2":
                    odds = 2;

                    var COLUMN2 = new List<int> { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
                    if (COLUMN2.Contains(winningNum.Number))
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "COLUMN3":
                    odds = 2;

                    var COLUMN3 = new List<int> { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
                    if (COLUMN3.Contains(winningNum.Number))
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "1stDOZEN":
                    odds = 2;

                    if (winningNum.Number >= 1 && winningNum.Number <= 12)
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "2ndDOZEN":
                    odds = 2;

                    if (winningNum.Number >= 13 && winningNum.Number <= 24)
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "3rdDOZEN":
                    odds = 2;

                    if (winningNum.Number >= 25 && winningNum.Number <= 36)
                    {
                        payout = bet.Amount * odds;
                    }

                    break;
                case "STRAIGHT":
                    odds = 35;
                    if (winningNum.Number == bet.Number)
                    {
                        payout = bet.Amount * odds;
                    }
                    break;
                case "SPLIT":
                    odds = 17;
                    break;
                case "STREET":
                    odds = 11;
                    break;
                case "CORNER":
                    odds = 8;
                    break;
                case "BASKET":
                    odds = 6;
                    break;
                default:
                    // code block
                    break;
            }


            return payout;
        }



        // POST api/<RouletteController>
        [HttpPost("Bet")]
        public async Task<Bet> Post(string type, int amount, int? numbers)
        {
            Bet bet = new Bet()
            {
                Type = type,
                Amount = amount,
                Number = numbers
            };

            _rouletteContext.Add(bet);
            await _rouletteContext.SaveChangesAsync();

            return bet;
        }


        [HttpGet("ShowPreviousSpins")]
        public async Task<List<WinningNumber>> ShowPreviousSpins()
        {
            var PreviousSpins = _rouletteContext.WinningNumbers.Take(10).ToList(); 

            return PreviousSpins;
        }



    }
}
