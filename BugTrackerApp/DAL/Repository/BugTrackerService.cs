using BugTrackerApp.DAL.Interface;
using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTrackerApp.DAL.Repository
{
    public class BugTrackerService : IBugTrackerInterface
    {
        private IBugTrackerRepository _repo;
        public BugTrackerService(IBugTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteBug(int BugId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Bug GetBugByID(int BugId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Bug> IBugTrackerInterface.GetBugs()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Bug IBugTrackerInterface.InsertBug(Bug Bug)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IBugTrackerInterface.UpdateBug(Bug Bug)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}