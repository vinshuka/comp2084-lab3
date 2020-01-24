using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3.Models;


namespace Lab3.Controllers
{
    public class PhoneController : Controller
    {
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone {phoneId = 1, phoneName = "Nexsus", manufacturer = "Samsung", MSRP = 399.00, screenSize = 5.2, dateReleased = new DateTime(2009, 6, 28) },
                new Phone {phoneId = 2, phoneName = "Idol 3", manufacturer = "Alcaltel", MSRP = 299.00, screenSize = 6.2, dateReleased = new DateTime(2013, 10, 14) },
                new Phone {phoneId = 3, phoneName = "Iphone 9S", manufacturer = "Apple", MSRP = 899.00, screenSize = 6.4, dateReleased = new DateTime(2018, 8, 3) },
                new Phone {phoneId = 4, phoneName = "Note 10", manufacturer = "Samsung", MSRP = 1199.00, screenSize = 8.2, dateReleased = new DateTime(2019, 4, 22) }
            };

            return View(phoneList);
        }

   
}
}