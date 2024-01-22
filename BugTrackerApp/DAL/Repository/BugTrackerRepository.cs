using BugTrackerApp.DAL.Interface;
using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BugTrackerApp.DAL.Repository
{
    public class BugTrackerRepository : IBugTrackerRepository
    {
        private BugTrackerDbContext _context;
        public BugTrackerRepository(BugTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Bug> GetBugs()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Bug GetBugByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Bug InsertBug(Bug Bug)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteBug(int BugID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateBug(Bug Bug)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
