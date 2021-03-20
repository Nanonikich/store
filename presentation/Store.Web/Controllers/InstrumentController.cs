using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class InstrumentController : Controller
    {
        private readonly IInstrumentRepository instrumentRepository;
        public InstrumentController(IInstrumentRepository instrumentRepository)
        {
            this.instrumentRepository = instrumentRepository;
        }
        public IActionResult Index(int id)
        {
            Instrument instrument = instrumentRepository.GetById(id);
            return View(instrument);
        }
    }
}
