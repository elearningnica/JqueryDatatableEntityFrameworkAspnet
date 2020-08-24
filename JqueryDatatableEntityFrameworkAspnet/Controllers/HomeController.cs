using JqueryDatatableEntityFrameworkAspnet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JqueryDatatableEntityFrameworkAspnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> loadData()
        {
            var data = await getData();
            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }

        private async Task<List<Customer>> getData()
        {
            using (AdventureWorksDW2017Entities entities = new AdventureWorksDW2017Entities())
            {
                List<Customer> customerList = new List<Customer>();

                var data = await entities.DimCustomer.Take(200).ToListAsync();

                foreach (var item in data)
                {
                    Customer modelo = new Customer();

                    modelo.Phone = item.Phone;
                    modelo.CustomerKey = item.CustomerKey;
                    modelo.FirstName = item.FirstName;
                    modelo.LastName = item.LastName;
                    modelo.EmailAddress = item.EmailAddress;

                    customerList.Add(modelo);
                }

                return customerList;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}