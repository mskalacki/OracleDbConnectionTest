using OracleTest2.Models;
using OracleTest2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OracleTest2.Controllers
{
    public class CountryController : Controller
    {
        private ICountryService _service;

        public CountryController (ICountryService service)
        {
            this._service = service;
        }

        public ActionResult GetAllCountries()
        {
            List<Country> Countries = _service.GetAllCountries();

            return Json(new
            {
                Countries
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddCountry (string code, string name, int region)
        {
            int insertStatus = _service.AddCountry(code, name, region);

            return Json(new
            {
                insertStatus
            }, JsonRequestBehavior.AllowGet);
        }
    }
}