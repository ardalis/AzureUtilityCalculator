namespace UtilityCalculator.Web.Models
{

    public class HeatCostResultViewModel
    {
        public int SizeInSquareFeet { get; set; }
        public string ClimateZone { get; set; }

        public decimal Cost { get; set; }
    }
}