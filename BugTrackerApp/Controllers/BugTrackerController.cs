using BugTrackerApp.DAL.Interface;
using BugTrackerApp.DAL.Repository;
using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerApp.Controllers
{
    public class BugTrackerController : Controller
    {
        private readonly IBugTrackerInterface _Repository;
        public BugTrackerController(IBugTrackerInterface service)
        {
            _Repository = service;
        }
        public BugTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: BugTracker
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException(); 
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Bug Bug)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(Bug Bug)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}