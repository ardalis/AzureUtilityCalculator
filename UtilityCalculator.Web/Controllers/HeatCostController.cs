using Microsoft.AspNetCore.Mvc;
using UtilityCalculator.Web.Model;
using UtilityCalculator.Web.Models;
using UtilityCalculator.Web.Services;

namespace UtilityCalculator.Web.Controllers
{
    public class HeatCostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new HeatCostViewModel());
        }

        [HttpPost]
        public IActionResult Index(HeatCostViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var cost = HeatCalculatorService.CalculateCost(model.SizeInSquareFeet, ClimateZone.FromValue(model.ClimateZoneId).Code);
            var resultModel = new HeatCostResultViewModel()
            {
                ClimateZone = ClimateZone.FromValue(model.ClimateZoneId).Name,
                SizeInSquareFeet = model.SizeInSquareFeet,
                Cost = cost
            };
            return View("Result", resultModel);
        }

    }
}
