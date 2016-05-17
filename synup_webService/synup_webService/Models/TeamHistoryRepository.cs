using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class TeamHistoryRepository
    {
        static synupEntities _dataContext = new synupEntities();

        public static List<spTeHisLogI_Result> GetInsertedTeamHistory(string employeeId, int first, int last)
        {
            return _dataContext.spTeHisLogI(employeeId, first, last).ToList();
        }

        public static List<spTeHisLogU_Result> GetUpdatedTeamHistory(string employeeId, int first, int last)
        {
            return _dataContext.spTeHisLogU(employeeId, first, last).ToList();
        }

        public static List<spTeHisLogD_Result> GetDeletedTeamHistory(string employeeId, int first, int last)
        {
            return _dataContext.spTeHisLogD(employeeId, first, last).ToList();
        }
    }
}