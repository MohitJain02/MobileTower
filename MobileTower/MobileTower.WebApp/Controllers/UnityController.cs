using MobileTower.WebApp.Services;
using System.Web.Mvc;
using Test.Logging;

namespace MobileTower.WebApp.Controllers
{
    public class UnityController : Controller
    {
        private IPriceCalculator priceCalculator;
        private ILogger _logger;

        public UnityController(IPriceCalculator priceCalculator, ILogger logger)
        {
            this.priceCalculator = priceCalculator;
            _logger = logger;
        }
        // GET: Unity
        public ActionResult Index()
        {
            string value = priceCalculator.CalculatePrice();
            _logger.LogInfo("Price Added to the calculator");
            return View();
        }
    }
}