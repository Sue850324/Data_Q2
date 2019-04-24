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

            int listnumber = rnd.Next(1, 4);
            int TicketTotal = 0;
            int TimeTotal = 0;
            int AvergeTotal = 0;
            int Count = 0;

            switch (listnumber)
            {
                case 1:
                    string filepath1 = Server.MapPath("~/App_Data/data1.json");
                    string json1 = System.IO.File.ReadAllText(filepath1);

                    List<DataModel> list1 = JsonConvert.DeserializeObject<List<DataModel>>(json1);
                    foreach (var item in list1)
                    {
                        TicketTotal = TicketTotal + item.Ticket;
                        item.TicketSum = TicketTotal; //Ticket數量相加
                    }
                    foreach (var item in list1)
                    {
                        Count = Count + 1;
                        TimeTotal = TimeTotal + item.ResponseMinutes;
                        item.RespositeTime = TimeTotal; //回應時間相加                     
                        item.AvergeTime = item.RespositeTime /Count ;
                        TimeSpan ts = new TimeSpan(0, (int)item.AvergeTime, 0);
                        item.day = ts.Days;
                        item.hr = ts.Hours;
                        item.minute = ts.Minutes;
                    }
                    return View(list1);

                case 2:
                    string filepath2 = Server.MapPath("~/App_Data/data2.json");
                    string json2 = System.IO.File.ReadAllText(filepath2);

                    List<DataModel> list2 = JsonConvert.DeserializeObject<List<DataModel>>(json2);
                    foreach (var item in list2)
                    {
                        TicketTotal = TicketTotal + item.Ticket;
                        item.TicketSum = TicketTotal;
                    }
                    foreach (var item in list2)
                    {
                        Count = Count + 1;
                        TimeTotal = TimeTotal + item.ResponseMinutes;
                        item.RespositeTime = TimeTotal;
                        item.AvergeTime = item.RespositeTime / Count;
                        TimeSpan ts = new TimeSpan(0, (int)item.AvergeTime, 0);
                        item.day = ts.Days;
                        item.hr = ts.Hours;
                        item.minute = ts.Minutes;
                    }
                    return View(list2);

                default:
                    string filepath3 = Server.MapPath("~/App_Data/data3.json");
                    string json3 = System.IO.File.ReadAllText(filepath3);
                    List<DataModel> list3 = JsonConvert.DeserializeObject<List<DataModel>>(json3);
                    foreach (var item in list3)
                    {
                        TicketTotal = TicketTotal + item.Ticket;
                        item.TicketSum = TicketTotal;
                    }
                    foreach (var item in list3)
                    {
                        Count = Count + 1;
                        TimeTotal = TimeTotal + item.ResponseMinutes;
                        item.RespositeTime = TimeTotal;
                        item.AvergeTime = item.RespositeTime / Count;
                        TimeSpan ts = new TimeSpan(0, (int)item.AvergeTime, 0);
                        item.day = ts.Days;
                        item.hr = ts.Hours;
                        item.minute = ts.Minutes;
                    }
                    return View(list3);
            }
        }
    }
}