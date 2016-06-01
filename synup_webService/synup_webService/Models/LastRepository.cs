using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synup_webService.Models
{
    public class LastRepository
    {

        public static List<spLast_Result> GetLast()
        {
            List<spLast_Result> _lasts;

            using (var _dataContext = new synupEntities())
            {
                _lasts = new List<spLast_Result>();
                _lasts = _dataContext.spLast().ToList();
            }

            return _lasts;
        }


    }
}