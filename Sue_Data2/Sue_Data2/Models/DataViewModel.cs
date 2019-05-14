using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Suec_Data2.Models
{
    public class DataViewModel
    {
        public List<DataModel> DataList {set;get;}
        public DataModel SingleData { get; set; }
        public int Day { set; get; }
        public int Hour { set; get; }
        public int Minutes { set; get; }
    }

}