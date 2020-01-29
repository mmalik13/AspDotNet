using StudentsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            return View(MvcApplication.addressList);
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {
            Address address = MvcApplication.addressList.Where(s => s.Id == id).FirstOrDefault();
            return View(address);
        }

        // GET: Address/Create
        public ActionResult Create()
        {   
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        public ActionResult Create(Address address)
        {
            try
            {
                address.Id = ++MvcApplication.addressesIdCount;
                MvcApplication.addressList.Add(address);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            Address address = MvcApplication.addressList.Where(a => a.Id == id).SingleOrDefault();
            return View(address);
        }

        // POST: Address/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Address address)
        {
            try
            {
                Address tempAddress = MvcApplication.addressList.Where(a => a.Id == id).SingleOrDefault();
                tempAddress.City = address.City;
                tempAddress.Street = address.Street;
                tempAddress.PostalCode = address.PostalCode;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            Address address = MvcApplication.addressList.Where(a => a.Id == id).SingleOrDefault();
            return View(address);
        }

        // POST: Address/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Address tempAddress = MvcApplication.addressList.Where(a => a.Id == id).SingleOrDefault();
                MvcApplication.addressList.Remove(tempAddress);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
