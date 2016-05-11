using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class TeamRepository
    {
        static synupEntities _dataContext = new synupEntities();

        public static List<Team> GetInsertedTeam(string employeeId, int first, int last)
        {
            return _dataContext.spTeamLogI(employeeId, first, last).ToList();
        }

        public static List<Team> GetUpdatedTeam(string employeeId, int first, int last)
        {
            return _dataContext.spTeamLogU(employeeId, first, last).ToList();
        }

        public static List<Team> GetDeletedTeam(string employeeId, int first, int last)
        {
            return _dataContext.spTeamLogD(employeeId, first, last).ToList();
        }
    }
}