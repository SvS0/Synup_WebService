using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class TaskHistoryRepository
    {
        static synupEntities _dataContext = new synupEntities();

        public static List<TaskHistory> GetInsertedTaskHistory(string employeeId, int first, int last)
        {
            return _dataContext.spTHisLogI(employeeId, first, last).ToList();
        }

        public static List<TaskHistory> GetUpdatedTaskHistory(string employeeId, int first, int last)
        {
            return _dataContext.spTHisLogU(employeeId, first, last).ToList();
        }

        public static List<TaskHistory> GetDeletedTaskHistory(string employeeId, int first, int last)
        {
            return _dataContext.spTHisLogD(employeeId, first, last).ToList();
        }
    }
}