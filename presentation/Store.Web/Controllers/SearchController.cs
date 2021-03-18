using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly InstrumentService instrumentService;

        public SearchController(InstrumentService instrumentService)
        {
            this.instrumentService = instrumentService;
        }

        public IActionResult Index(string query)
        {
            var instruments = instrumentService.GetAllByQuery(query);
            
            return View(instruments);
        }
    }
}
