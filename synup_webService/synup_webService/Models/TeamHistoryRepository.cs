using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class TeamHistoryRepository
    {
        static synupEntities _dataContext = new synupEntities();

        public static List<TeamHistory> GetInsertedTeamHistory(string employeeId, int first, int last)
        {
            List<TeamHistory> _teamHistories;

            using (var _dataContext = new synupEntities())
            {
                _teamHistories = new List<TeamHistory>();
                _teamHistories = _dataContext.spTeHisLogI(employeeId,first, last).ToList();
            }

            return _teamHistories;
        }

        public static List<TeamHistory> GetUpdatedTeamHistory(string employeeId, int first, int last)
        {
            List<TeamHistory> _teamHistories;

            using (var _dataContext = new synupEntities())
            {
                _teamHistories = new List<TeamHistory>();
                _teamHistories = _dataContext.spTeHisLogU(employeeId, first, last).ToList();
            }

            return _teamHistories;
        }

        public static List<TeamHistory> GetDeletedTeamHistory(string employeeId, int first, int last)
        {
            List<TeamHistory> _teamHistories;

            using (var _dataContext = new synupEntities())
            {
                _teamHistories = new List<TeamHistory>();
                _teamHistories = _dataContext.spTeHisLogD(employeeId, first, last).ToList();
            }

            return _teamHistories;
        }

    }
}