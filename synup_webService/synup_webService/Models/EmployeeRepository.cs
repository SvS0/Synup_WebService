using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class EmployeeRepository
    {
        static synupEntities _dataContext = new synupEntities();

        public static List<Employee> GetInsertedEmployee(int first, int last)
        {
            return _dataContext.spEmpLogI(first, last).ToList();
        }

        public static List<Employee> GetUpdatedEmployee(int first, int last)
        {
            return _dataContext.spEmpLogU(first, last).ToList();
        }

        public static List<Employee> GetDeletedEmployee(int first, int last)
        {
            return _dataContext.spEmpLogD(first, last).ToList();
        }

        public static List<Employee> GetLogin(string username, string password)
        {
            return _dataContext.spLogin(username, password).ToList();
        }

    }
}