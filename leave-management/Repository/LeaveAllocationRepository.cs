using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveAllocationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Create(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocation.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocation.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            return _dbContext.LeaveAllocation.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            return _dbContext.LeaveAllocation.Find(id);
        }

        public bool IsExists(int id)
        {
            var exists = _dbContext.LeaveAllocation.Any(lt => lt.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _dbContext.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocation.Update(entity);
            return Save();
        }
    }
}
