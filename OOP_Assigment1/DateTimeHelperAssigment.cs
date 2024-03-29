﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment1
{
    public static class DateTimeHelperAssigment
    {

        public static int CalculateAge(DateTime birthDate)
        {
            //Assigment 7: Calculate the age of the person born using the birthDate parameter.
            throw new NotImplementedException();
        }

        public static DateTime ConvertToDateTime(string date)
        {
            //Assigment 8: Convert the input string to a DateTime object.
            //The input string format is 2022-07-31

            //one way to solve it:
            var dateParts = date.Split('-');

            var newDate = new DateTime
                (int.Parse(dateParts[0]), 
                int.Parse(dateParts[1]), 
                int.Parse(dateParts[2]));

            //another way to solve it:
            return DateTime.Parse(date);
        }

        public static bool IsLeapYear(DateTime date)
        {
            //Assigment 9: Return true if date is leap year
            throw new NotImplementedException();
        }

        public static int DaysUntilNextBirthday(DateTime birthDate, DateTime currentTime)
        {
            //Assigment 10: Calculate the number of days until the next birthday.
            //Note that this is not easily unit tested because the result depends on the current date!!!
            //So this assignment is not tested in the unit tests.
            throw new NotImplementedException();
        }

        public static string GetCurrentDateTime()
        {
            //Assigment 11: Return the current date and time in the format: "yyyy-MM-dd HH:mm:ss".
            throw new NotImplementedException();
        }
    }
}
