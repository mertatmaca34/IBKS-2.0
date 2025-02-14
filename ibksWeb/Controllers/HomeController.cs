using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ibksWeb.Models;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace ibksWeb.Controllers
{
    public class HomeController : BaseController
    {
        ISendDataService _sendDataManager;

        public HomeController(ISendDataService sendDataService)
        {
            _sendDataManager = sendDataService;
        }

        public IActionResult Index()
        {
            DateTime lastMinute = DateTime.Now.AddMinutes(-1);

            var latestData = _sendDataManager.GetAll().Data.LastOrDefault();

            return View(latestData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}

