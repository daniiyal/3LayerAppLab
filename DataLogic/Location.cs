using System;
using System.Collections.Generic;
using System.Text;

namespace DataLogic
{

    public class Prognoz
    {
        public string Date { get; set; }
        public double Temp { get; set; }
        public double Pressure { get; set; }
        public double Wet { get; set; }
        public double Osadki { get; set; }
    }

    public class Location
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string Area { get; set; }
        public List<Prognoz> Prognoz { get; set; }
    }

    public class Root
    {
        public List<Location> Prognoz { get; set; }
    }

}
