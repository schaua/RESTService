using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTService.Models
{
    public class SimpleDataObject
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int Count { get; set; }
    }
}