using leave_mng.Contracts;
using leave_mng.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_mng.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveTypes.ToList();
        }
        public LeaveType FindById(int id)
        {
            return _db.LeaveTypes.Find(id);
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }
        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }

        public bool Delete(LeaveType item)
        {
            _db.LeaveTypes.Remove(item);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public ICollection<Employee> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
