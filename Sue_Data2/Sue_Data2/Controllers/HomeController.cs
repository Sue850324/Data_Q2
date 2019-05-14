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
            DataViewModel dataModel = new DataViewModel();
            Random rnd = new Random();
            int ResponseTime = 0;
            int AverageTime = 0;
            int Count = 0;
            int JsonFile = rnd.Next(0, 3);
            string[] File = { "~/App_Data/data1.json", "~/App_Data/data2.json", "~/App_Data/data3.json" };
            string ReadJson = System.IO.File.ReadAllText(Server.MapPath(File[JsonFile]));
            dataModel.DataList = JsonConvert.DeserializeObject<List<DataModel>>(ReadJson);

            foreach (var item in dataModel.DataList)
            {
                Count = Count + 1;
                ResponseTime = ResponseTime + item.ResponseMinutes;
                AverageTime = ResponseTime / Count;
            }

            TimeSpan ts = new TimeSpan(0, (int)AverageTime, 0);
            dataModel.Day = ts.Days;
            dataModel.Hour = ts.Hours;
            dataModel.Minutes = ts.Minutes;
            return View(dataModel);
        }

    }
}