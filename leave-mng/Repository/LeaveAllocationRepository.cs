using leave_mng.Contracts;
using leave_mng.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_mng.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveAllocation item)
        {
            _db.Add(item);
            return Save();
        }

        public bool Delete(LeaveAllocation item)
        {
            _db.LeaveAllocations.Remove(item);
            return Save(); 
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            return _db.LeaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            return _db.LeaveAllocations.Find(id);
        }

        public bool Update(LeaveAllocation item)
        {
            _db.Add(item);
            return Save();
        }
        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Exists(int id)
        {
            var exists = _db.LeaveAllocations.Any(x => x.Id == id);
            return exists;
        }
    }
}
