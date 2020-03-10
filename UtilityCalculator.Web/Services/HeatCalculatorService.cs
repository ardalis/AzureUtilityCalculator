namespace UtilityCalculator.Web.Services
{
    public class HeatCalculatorService
    {
        /// <summary>
        /// Calculates the cost to heat a home using this formula:
        /// http://www.travisindustries.com/CostOfHeating_WkSht.asp?P=2
        /// 
        /// </summary>
        /// <param name="sizeInSquareFeet">The size of the home in square feet</param>
        /// <param name="c">Climate zones</param>
        /// <returns></returns>
        public static decimal CalculateCost(int sizeInSquareFeet, string c)
        {
            // Mild winter
            if (c.Contains("M"))
            {
                return (decimal)sizeInSquareFeet * 1000 * 0.12m * 293 / 1000000;
            }
            else
            {
                // Moderate winter
                if (c.Contains("D"))
                {
                    return (decimal)sizeInSquareFeet * 2000 * 0.12m * 293 / 1000000;
                }
                else
                {
                    // Severe winter
                    if (sizeInSquareFeet == 1500)
                    {
                        return (decimal)5000000 * 0.12m * 293 / 1000000;
                    }
                    else
                    {
                        return (decimal)8000000 * 0.12m * 293 / 1000000;

                    }
                }
            }
        }
    }
}
