using System;

namespace UtilityCalculator.Web.Services
{
    // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/pattern-matching
    public class TollCalculator
    {
        public decimal CalculateToll(object vehicle) =>
            vehicle switch
            {
                Car c => 2.00m,
                Taxi t => 3.50m,
                Bus b => 5.00m,
                DeliveryTruck t => 10.00m,
                { } => throw new ArgumentException("Not a known vehicle type", nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
    }
    public class Car
    {
        public int Passengers { get; set; }
    }
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }
    }
    public class Taxi
    {
        public int Fares { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }

}
