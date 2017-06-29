using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpicCalculatorWebApp.ViewModels
{
    public class VMStandardCalculator
    {
        [Display(Name = "First Number")]
        public double? FirstNum { get; set; }

        [Display(Name = "Second Number")]
        public double? SecondNum { get; set; }

        [Display(Name = "Operation")]
        public string OperationId { get; set; }

        public IEnumerable<string> Operations
        {
            get
            {
                return Enum.GetNames(typeof(StandardCalculatorOperations));
            }
        }
    }

    public enum StandardCalculatorOperations
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}