using Microsoft.AspNetCore.Mvc;
using cop3855web.Models;
using System.Linq;

namespace cop3855web.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}