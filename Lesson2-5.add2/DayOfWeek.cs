using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5.add2
{
    class DayOfWeek
    {
        private string[] day = new string[7] { "Monday", "Tusday", "Wensday", "Thursd", "Friday", "Saturday", "Sunday" };

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < day.Length)
                    return day[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

    }
}
