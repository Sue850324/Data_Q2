using Suec_Data2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.IO;


namespace Sue_Data2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Dashboard()

        {

            Random rnd = new Random();

            int listNumber = rnd.Next(1, 4);
            int ticketTotal = 0;
            int timeTotal = 0;
            int avergeTotal = 0;
            int count = 0;

            switch (listNumber)
            {
                case 1:
                    string filePath1 = Server.MapPath("~/App_Data/data1.json");
                    string json1 = System.IO.File.ReadAllText(filePath1);

                    List<DataModel> list1 = JsonConvert.DeserializeObject<List<DataModel>>(json1);
                    foreach (var item in list1)
                    {
                        ticketTotal = ticketTotal + item.Ticket;
                        item.TicketSum = ticketTotal; //Ticket數量相加
                    }
                    foreach (var item in list1)
                    {
                        count = count + 1;
                        timeTotal = timeTotal + item.ResponseMinutes;
                        item.RespositeTime = timeTotal; //回應時間相加                     
                        item.AvergeTime = item.RespositeTime /count ;
                        TimeSpan ts = new TimeSpan(0, (int)item.AvergeTime, 0);
                        item.Day = ts.Days;
                        item.Hr = ts.Hours;
                        item.Minute = ts.Minutes;
                    }
                    return View(list1);

                case 2:
                    string filePath2 = Server.MapPath("~/App_Data/data2.json");
                    string json2 = System.IO.File.ReadAllText(filePath2);

                    List<DataModel> list2 = JsonConvert.DeserializeObject<List<DataModel>>(json2);
                    foreach (var item in list2)
                    {
                        ticketTotal = ticketTotal + item.Ticket;
                        item.TicketSum = ticketTotal;
                    }
                    foreach (var item in list2)
                    {
                        count = count + 1;
                        timeTotal = timeTotal + item.ResponseMinutes;
                        item.RespositeTime = timeTotal;
                        item.AvergeTime = item.RespositeTime / count;
                        TimeSpan ts = new TimeSpan(0, (int)item.AvergeTime, 0);
                        item.Day = ts.Days;
                        item.Hr = ts.Hours;
                        item.Minute = ts.Minutes;
                    }
                    return View(list2);

                default:
                    string filePath3 = Server.MapPath("~/App_Data/data3.json");
                    string json3 = System.IO.File.ReadAllText(filePath3);
                    List<DataModel> list3 = JsonConvert.DeserializeObject<List<DataModel>>(json3);
                    foreach (var item in list3)
                    {
                        ticketTotal = ticketTotal + item.Ticket;
                        item.TicketSum = ticketTotal;
                    }
                    foreach (var item in list3)
                    {
                        count = count + 1;
                        timeTotal = timeTotal + item.ResponseMinutes;
                        item.RespositeTime = timeTotal;
                        item.AvergeTime = item.RespositeTime / count;
                        TimeSpan ts = new TimeSpan(0, (int)item.AvergeTime, 0);
                        item.Day = ts.Days;
                        item.Hr = ts.Hours;
                        item.Minute = ts.Minutes;
                    }
                    return View(list3);
            }
        }
    }
}