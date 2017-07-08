using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpicCalculatorWebApp.ViewModels
{
    public class VMScientificCalculator
    {
        [Display(Name = "Base")]
        public double? BaseNumber { get; set; }

        [Display(Name = "Power")]
        public double? PowerNumber { get; set; }
        public double? Number { get; set; }

        [Display(Name = "Log Base")]
        public double? LogBase { get; set; }

        public double? Angle { get; set; }

        [Display(Name = "Operation")]
        public string OperationId { get; set; }

        public IEnumerable<string> Operations
        {
            get
            {
                return Enum.GetNames(typeof(ScientificCalculatorOperations));
            }
        }
    }

    public enum ScientificCalculatorOperations
    {
        Power,
        Log,
        Sin,
        Cos,
        Tan
    }
}