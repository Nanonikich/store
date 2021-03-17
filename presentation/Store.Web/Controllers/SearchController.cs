using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IInstrumentRepository instrumentRepository;

        public SearchController(IInstrumentRepository instrumentRepository)
        {
            this.instrumentRepository = instrumentRepository;
        }

        public IActionResult Index(string query)
        {
            var instruments = instrumentRepository.GetAllByTitle(query);
            return View(instruments);
        }
    }
}
