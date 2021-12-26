using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ShopsRUs.Models;
using ShopsRUs.Bussines;

namespace ShopsRUs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        public InvoiceController()
        {
            DataRepository _repo = new DataRepository();
            _repo.Insert();
        }
 
        [HttpGet]
        [Route("GetInvoiceID")]
        public IActionResult GetInvoiceID(int id)
        {
            var p = DataRepository._invoices.FirstOrDefault(i => i.InvoiceId == id);
            if (p == null)
            {
                return NotFound();
            }

           Price _price = new Price();

            decimal price = 0;
            if (p.price > 0)
                price = _price.GetPrice(p.InvoiceId);

            return Ok(price);
        }
    }
}
