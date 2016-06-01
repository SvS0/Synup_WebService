using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class TeamRepository
    {

        public static List<Team> GetInsertedTeam(string employeeId, int first, int last)
        {
            List<Team> _teams;

            using (var _dataContext = new synupEntities())
            {
                _teams = new List<Team>();
                _teams = _dataContext.spTeamLogI(employeeId, first, last).ToList();
            }

            return _teams;
        }

        public static List<Team> GetUpdatedTeam(string employeeId, int first, int last)
        {
            List<Team> _teams;

            using (var _dataContext = new synupEntities())
            {
                _teams = new List<Team>();
                _teams = _dataContext.spTeamLogU(employeeId, first, last).ToList();
            }

            return _teams;
        }

        public static List<Team> GetDeletedTeam(string employeeId, int first, int last)
        {
            List<Team> _teams;

            using (var _dataContext = new synupEntities())
            {
                _teams = new List<Team>();
                _teams = _dataContext.spTeamLogD(employeeId, first, last).ToList();
            }

            return _teams;
        }
    }
}