﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    internal class EmployeewageUC4
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static void EmployeeWageswitchcase()
        {
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            switch (num)
            {
                case IS_FULL_TIME:
                    emphrs = 12;
                    break;
                case IS_PART_TIME:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;

            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee wage of the day is :" + empwage);
        }
}
