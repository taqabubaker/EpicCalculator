using EpicCalculator.BL;
using EpicCalculatorWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpicCalculatorWebApp.Controllers
{
    public class StandardCalculatorController : BaseController
    {
        public StandardCalculatorController(IEpicCalculatorClient client) : base(client)
        { }

        // GET: StandardOperations
        public ActionResult Index()
        {
            VMStandardCalculator model = new VMStandardCalculator();
            return View(model);
        }

        [HttpPost]
        public ActionResult Calculate(VMStandardCalculator model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("_Result", null);
                }

                var operation = (StandardCalculatorOperations)Enum.Parse(typeof(StandardCalculatorOperations), 
                    model.OperationId);
                double result;

                switch (operation)
                {
                    case StandardCalculatorOperations.Add:
                        result = _client.Add(model.FirstNum.Value, model.SecondNum.Value);
                        break;
                    case StandardCalculatorOperations.Subtract:
                        result = _client.Subtract(model.FirstNum.Value, model.SecondNum.Value);
                        break;
                    case StandardCalculatorOperations.Multiply:
                        result = _client.Multiply(model.FirstNum.Value, model.SecondNum.Value);
                        break;
                    case StandardCalculatorOperations.Divide:
                        result = _client.Divide(model.FirstNum.Value, model.SecondNum.Value);
                        break;
                    default:
                        throw new Exception("Invalid operation!");
                }

                return PartialView("_Result", result);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return PartialView("_Result", null);
            }
        }
    }
}