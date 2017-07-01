using EpicCalculator.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpicCalculatorWebApp.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IEpicCalculatorClient _client;

        public BaseController(IEpicCalculatorClient client)
        {
            _client = client;
        }
    }
}