using Ardalis.SmartEnum;

namespace UtilityCalculator.Web.Model
{
    public class ClimateZone : SmartEnum<ClimateZone, int>
    {
        public static ClimateZone Mild = new ClimateZone(nameof(Mild), 1, "M");
        public static ClimateZone Moderate = new ClimateZone(nameof(Moderate), 2, "D");
        public static ClimateZone Severe = new ClimateZone(nameof(Severe), 3, "S");

        public string Code { get; private set; }

        public ClimateZone(string name, int value, string code) : base(name, value)
        {
            Code = code;
        }
    }
}
