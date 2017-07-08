using EpicCalculator.BL;
using EpicCalculatorWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpicCalculatorWebApp.Controllers
{
    public class ScientificCalculatorController : BaseController
    {
        public ScientificCalculatorController(IEpicCalculatorClient client) : base(client)
        { }

        // GET: ScientificCalculator
        public ActionResult Index()
        {
            VMScientificCalculator model = new VMScientificCalculator();
            return View(model);
        }

        [HttpPost]
        public ActionResult Calculate(VMScientificCalculator model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("_Result", null);
                }

                var operation = (ScientificCalculatorOperations)Enum.Parse(typeof(ScientificCalculatorOperations),
                    model.OperationId);
                double result;

                switch (operation)
                {
                    case ScientificCalculatorOperations.Power:
                        result = _client.Power(model.BaseNumber.Value, model.PowerNumber.Value);
                        break;
                    case ScientificCalculatorOperations.Log:
                        result = _client.Log(model.Number.Value, model.LogBase.Value);
                        break;
                    case ScientificCalculatorOperations.Sin:
                        result = _client.Sin(model.Angle.Value);
                        break;
                    case ScientificCalculatorOperations.Cos:
                        result = _client.Cos(model.Angle.Value);
                        break;
                    case ScientificCalculatorOperations.Tan:
                        result = _client.Tan(model.Angle.Value);
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