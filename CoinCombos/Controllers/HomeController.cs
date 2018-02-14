using Microsoft.AspNetCore.Mvc;
using CoinCombos.Models;
using System;
using System.Collections.Generic;
namespace CoinCombos.Controllers
{
    public class CoinCombosController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index ()
        {
            return View();
        }


        [HttpPost("/")]
        public ActionResult MakeChange()
        {
            int amount = Int32.Parse(Request.Form["amount"]);
            Coins newCoins = new Coins(amount);
            string changeString = newCoins.GetCoins();
            return View("/", changeString);
        }
    }
}
