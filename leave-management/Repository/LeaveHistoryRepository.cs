using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveHistoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Create(LeaveHistory entity)
        {
            _dbContext.LeaveHistory.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _dbContext.LeaveHistory.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            return _dbContext.LeaveHistory.ToList();
        }

        public LeaveHistory FindById(int id)
        {
            return _dbContext.LeaveHistory.Find(id);
        }

        public bool IsExists(int id)
        {
            var exists = _dbContext.LeaveHistory.Any(lt => lt.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _dbContext.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _dbContext.LeaveHistory.Update(entity);
            return Save();
        }
    }
}
