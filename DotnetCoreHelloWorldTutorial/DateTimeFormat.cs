﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    class DateTimeFormat
    {
        public void Format()
        {

            List<string> dates = new List<string>();

            //dates[0]
            //lst.Add("10");
            //lst.Add("20th Oct 2052");
            //lst.Add("6th Jun 1933");
            //lst.Add("26th May 1960");
            //lst.Add("20th Sep 1958");

            //lst.RemoveAt(0);
            List<string> newLst = new List<string>();
            foreach (var item in dates)
            {
                var data = item.Split(" ");
                var month = "";
                switch (data[1])
                {
                    case "Jan": month = "1"; break;
                    case "Feb": month = "2"; break;
                    case "Mar": month = "3"; break;
                    case "Apr": month = "4"; break;
                    case "May": month = "5"; break;
                    case "Jun": month = "6"; break;
                    case "Jul": month = "7"; break;
                    case "Aug": month = "8"; break;
                    case "Sep": month = "9"; break;
                    case "Oct": month = "10"; break;
                    case "Nov": month = "11"; break;
                    case "Dec": month = "12"; break;
                }

                var dateString = data[0];

                var length = dateString.Length - 2;
                var newDateString = dateString.Substring(0, length);

                newLst.Add(string.Format("{0}-{1}-{2}", data[2], month, newDateString));
            }
        }
    }
}
