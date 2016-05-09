using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class TaskRepository
    {
        static synupEntities _dataContext = new synupEntities();

        public static List<Task> GetInsertedTask(int employeeId, int first, int last)
        {
            return _dataContext.spTasklogI(employeeId, first, last).ToList();
        }

        public static List<Task> GetUpdatedTask(int employeeId, int first, int last)
        {
            return _dataContext.spTasklogU(employeeId, first, last).ToList();
        }

        public static List<Task> GetDeletedTask(int employeeId, int first, int last)
        {
            return _dataContext.spTasklogD(employeeId, first, last).ToList();
        }
    }
}
