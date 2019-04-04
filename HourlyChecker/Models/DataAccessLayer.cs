using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HourlyChecker.Models
{
    public class DataAccessLayer
    {
        private readonly HourCheckerContext _context;

        public DataAccessLayer(HourCheckerContext context)
        {
            this._context = context;
        }

        public void addUser(DataTable data)
        {
            _context.DataTable.Add(data);
            _context.SaveChanges();
        }

        public bool onCheck(latestdatetime datetime)
        {
            var latestrecordhour = _context.DataTable.OrderByDescending(latest => latest.Hour).Take(1);
            int convertedhours = 0 ;
            int convertedminutes = 0;
            string record = "";
           foreach (var hour in latestrecordhour)
            {
                convertedhours = Convert.ToInt32(hour.Hour);
                convertedminutes = Convert.ToInt32(hour.Minutes);
                record = Convert.ToString(hour.Email);
            }
            //var latestrecordminutes = _context.DataTable.OrderByDescending(latest => latest.Minutes).Take(1).ToString();
            //var record = _context.DataTable.OrderByDescending(latest => latest.Email).Take(1).ToString();
            Console.WriteLine(latestrecordhour);
           // int convertedhours = Convert.ToInt32(latestrecordhour);  //converted hours
            //int convertedminutes = Convert.ToInt32(latestrecordminutes);    //converted minutes
            if ((datetime.hours > 7) && (datetime.hours < 20) && ((datetime.hours - convertedhours) == 0 || (datetime.hours - convertedhours) == 1))
            {
                if ((((datetime.minutes - convertedminutes) > 0)) || record == null)
                {
                    return false;
                }
                else
                    return true;
            }

            return false;
        }

        public class latestdatetime
        {
            public int hours { get; set; }
            public int minutes { get; set; }
            public int date { get; set; }
        }
    }
}
