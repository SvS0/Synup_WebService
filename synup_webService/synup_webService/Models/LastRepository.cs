using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class LastRepository
    {

        static synupEntities _dataContext = new synupEntities();

        public static List<spLast_Result> GetLast(int employeeId)
        {
            return _dataContext.spLast(employeeId).ToList();  
        }

        public static void Submit()
        {
            try
            {
                _dataContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                closeBD();
            }
        }
        public static void closeBD()
        {
            _dataContext.Database.Connection.Close();
        }
    }
}