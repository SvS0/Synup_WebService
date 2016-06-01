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
            List<Employee> _employees;

            using (var _dataContext = new synupEntities())
            {
                _employees = new List<Employee>();
                _employees = _dataContext.spEmpLogI(first, last).ToList();
            }

            return _employees;
        }

        public static List<Employee> GetUpdatedEmployee(int first, int last)
        {
            List<Employee> _employees;

            using (var _dataContext = new synupEntities())
            {
                _employees = new List<Employee>();
                _employees = _dataContext.spEmpLogU(first, last).ToList();
            }

            return _employees;
        }

        public static List<Employee> GetDeletedEmployee(int first, int last)
        {
            List<Employee> _employees;

            using (var _dataContext = new synupEntities())
            {
                _employees = new List<Employee>();
                _employees = _dataContext.spEmpLogD(first, last).ToList();
            }

            return _employees;
        }

        public static List<Employee> GetLogin(string username, string password)
        {
            List<Employee> _employees;

            using (var _dataContext = new synupEntities())
            {
                _employees = new List<Employee>();
                _employees = _dataContext.spLogin(username, password).ToList();
            }

            return _employees;
        }

    }
}