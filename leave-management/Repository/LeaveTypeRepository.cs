using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveTypeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Create(LeaveType entity)
        {
            _dbContext.LeaveType.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _dbContext.LeaveType.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _dbContext.LeaveType.ToList();
        }

        public LeaveType FindById(int id)
        {
            var leaveType = _dbContext.LeaveType.Find(id);
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _dbContext.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveType entity)
        {
            _dbContext.LeaveType.Update(entity);
            return Save();
        }
    }
}
