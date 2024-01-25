using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class CheckDateTime
    {
        public static int[] Month = new int[13] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static bool CheckLeapYear(int year)
        {
            if(year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            }
            return false;
        }
        public static bool checkDateTime(int day, int month, int year)
        {
            if(year < 0 || month < 0 || month > 12 || year > DateTime.Now.Year) return false;
            if(year == DateTime.Now.Year)
            {
                if(month == DateTime.Now.Month)
                {
                    if(day > DateTime.Now.Day)
                    {
                        return false;
                    }
                }
                else if(month > DateTime.Now.Month)
                {
                    return false;
                }
            }
            if(month == 2)
            {
                if(CheckLeapYear(year))
                {
                    if (day < 0 || day > 29) return false;
                }
                else
                {
                    if (day < 0 || day > 28) return false;
                }
                return true;
            }
            else
            {
                if (day < 0 || day > Month[month]) return false;
            }
            return true;
        }
    }
}
