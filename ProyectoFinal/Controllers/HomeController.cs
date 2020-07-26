using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<PaisViewModel> paisesViewModel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Covid()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            paisesViewModel = new List<PaisViewModel>();
            using var stream = System.IO.File.Open("owid-covid-data.xlsx", FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            do
            {
                reader.Read();
                while (reader.Read())
                    paisesViewModel.Add(new PaisViewModel(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), Convert.ToDouble(reader.GetValue(4)), Convert.ToDouble(reader.GetValue(5)), Convert.ToDouble(reader.GetValue(6)), Convert.ToDouble(reader.GetValue(7)), Convert.ToDouble(reader.GetValue(8)), Convert.ToDouble(reader.GetValue(9)), Convert.ToDouble(reader.GetValue(10)), Convert.ToDouble(reader.GetValue(11)), Convert.ToDouble(reader.GetValue(12)), Convert.ToDouble(reader.GetValue(13)), Convert.ToDouble(reader.GetValue(14)), Convert.ToDouble(reader.GetValue(15)), Convert.ToDouble(reader.GetValue(16)), Convert.ToDouble(reader.GetValue(17)), reader.GetString(18), Convert.ToDouble(reader.GetValue(19)), Convert.ToDouble(reader.GetValue(20)), Convert.ToDouble(reader.GetValue(21)), Convert.ToDouble(reader.GetValue(22)), Convert.ToDouble(reader.GetValue(23)), Convert.ToDouble(reader.GetValue(24)), Convert.ToDouble(reader.GetValue(25)), Convert.ToDouble(reader.GetValue(26)), Convert.ToDouble(reader.GetValue(27)), Convert.ToDouble(reader.GetValue(28)), Convert.ToDouble(reader.GetValue(29)), Convert.ToDouble(reader.GetValue(30)), Convert.ToDouble(reader.GetValue(31)), Convert.ToDouble(reader.GetValue(32)), Convert.ToDouble(reader.GetValue(33))));
            } while (reader.NextResult());

            return View();
        }

        [HttpGet]
        public IEnumerable<string> GetDates() => paisesViewModel.Select(x => x.Date).Distinct().ToList().OrderBy(x => x);

        [HttpGet]
        public IEnumerable<PaisViewModel> GetDataByDate(string Date) => paisesViewModel.Where(x => x.Date == Date);

        [HttpGet]
        public IEnumerable<PaisViewModel> GetDataByCountry(string Country) => paisesViewModel.Where(x => x.Location == Country);
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
