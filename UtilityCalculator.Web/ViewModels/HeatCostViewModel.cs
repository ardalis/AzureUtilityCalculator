using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace UtilityCalculator.Web.Models
{

    public class HeatCostViewModel
    {
        public HeatCostViewModel()
        {
            ClimateZones = Model.ClimateZone.List
                .Select(z => new SelectListItem(z.Name, z.Value.ToString()))
                .ToList();
        }
        [Required]
        [Display(Name = "Building Size (square feet)")]
        public int SizeInSquareFeet { get; set; }

        [Required]
        [Display(Name ="Climate Zone")]
        public int ClimateZoneId { get; set; }

        public List<SelectListItem> ClimateZones { get; set; } 
    }
}