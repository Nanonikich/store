using Microsoft.AspNetCore.Mvc;
using Store.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IInstrumentRepository instrumentRepository;

        public CartController(IInstrumentRepository instrumentRepository)
        {
            this.instrumentRepository = instrumentRepository;
        }
        public IActionResult Add(int id)
        {
            var instrument = instrumentRepository.GetById(id);
            Cart cart;
            if (!HttpContext.Session.TryGetCart(out cart))
                cart = new Cart();
            if (cart.Items.ContainsKey(id))
                cart.Items[id]++;
            else
                cart.Items[id] = 1;

            cart.Amount += instrument.Price;

            HttpContext.Session.Set(cart);

            return RedirectToAction("Index", "Instrument", new { id });
        }
    }
}
