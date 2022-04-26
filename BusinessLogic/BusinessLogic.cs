using DataLogic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace BusinessLogic
{
    public class BusinessLogicClass
    { 

        
        DataBase db = new DataBase();

        public IEnumerable<string> Get_Countries()
        {
            
            List<string> countries = new List<string>();
            

            foreach (var prog in db.ParseJSON())
            {
                countries.Add(prog.Country);
            }

            var country = countries.Distinct();

            return country;
        }

        public IEnumerable<string> Get_Regions(string country)
        {

            List<string> regions = new List<string>();

            foreach (var prog in db.ParseJSON())
            {
                if (country != "")
                {
                    if (prog.Country == country)
                    {
                        regions.Add(prog.Region);
                    }
                }
                else
                {
                    regions.Add(prog.Region);
                }

            }

            var region = regions.Distinct();

            return region;
        }

        public IEnumerable<string> Get_Areas(string country, string region)
        {

            List<string> areas = new List<string>();


            foreach (var prog in db.ParseJSON())
            {
                if(country != "" && region != "")
                {
                    if (prog.Country == country && prog.Region == region)
                    {
                        areas.Add(prog.Area);
                    }
                }
                else
                {
                    areas.Add(prog.Area);
                }
                
            }

            var area = areas.Distinct();


            return area;
        }



        public List<DateTime> Set_Date(string country, string region, string area)
        {

            var prognozes = db.ParseJSON();
            List<DateTime> dates = new List<DateTime>();
            DateTime min = new DateTime(1800, 1, 1);
            DateTime max = new DateTime(2099, 1, 1);
            dates.Add(min);
            dates.Add(max);
            foreach (var prog in prognozes)
            {
                if (prog.Country == country && prog.Region == region && 
                    prog.Area == area && prog.Prognoz.Count != 0)
                {
                    min = db.Get_Date(prog.Prognoz[0].Date);
                    max = db.Get_Date(prog.Prognoz[0].Date);
                    for (int i = 0; i < prog.Prognoz.Count; i++)
                    {
                        if (min > db.Get_Date(prog.Prognoz[i].Date))
                        {
                            min = db.Get_Date(prog.Prognoz[i].Date);
                        }
                        if (max < db.Get_Date(prog.Prognoz[i].Date))
                        {
                            max = db.Get_Date(prog.Prognoz[i].Date);
                        }
                    }

                    dates[0] = min;
                    dates[1] = max;
                }
            }    
            return dates;
        }
        public double Get_Rain(DateTime time, string interval,
                             string country, string region, string area)
        {
            double osadki = 0;
            

            foreach (var prog in db.ParseJSON())
            {
                if (prog.Country == country && prog.Region == region && 
                    prog.Area == area && prog.Prognoz.Count != 0)
                {
                    switch (interval)
                    {
                        case "День":
                            for (int i = 0; i < prog.Prognoz.Count; i++)
                            {

                                if (time.Day == db.Get_Date(prog.Prognoz[i].Date).Day &&
                                    time.Month == db.Get_Date(prog.Prognoz[i].Date).Month &&
                                    time.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                                    
                                {
                                    osadki += prog.Prognoz[i].Osadki;
                                }
                            }
                            return osadki;
                        case "Неделя":
                            for (int i = 0; i < prog.Prognoz.Count; i++)
                            {
                                if (ISOWeek.GetWeekOfYear(time.Date) == ISOWeek.GetWeekOfYear(db.Get_Date(prog.Prognoz[i].Date)) &&
                                    time.Date.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                                {
                                    osadki += prog.Prognoz[i].Osadki;
                                }
                            }
                            return osadki;
                        case "Месяц":
                            for (int i = 0; i < prog.Prognoz.Count; i++)
                            {
                                if (time.Date.Month ==db.Get_Date(prog.Prognoz[i].Date).Month &&
                                    time.Date.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                                {
                                    osadki += prog.Prognoz[i].Osadki;
                                }
                            }
                            return osadki;

                        case "Год":
                            for (int i = 0; i < prog.Prognoz.Count; i++)
                            {
                                if (time.Date.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                                {
                                    osadki += prog.Prognoz[i].Osadki;
                                }
                            }
                            return osadki;
                    }


                }

            }
            return 0;
        }
       

        public List<Prognoz> Get_Average(string country, string region, string area)
        {
            List<Prognoz> props = new List<Prognoz>();
            
           
            double temp = 0,
                   wet = 0,
                   osadki = 0,
                   pressure = 0;

            int count = 0;
            foreach (var prog in db.ParseJSON())
            {
                if (prog.Country == country && prog.Region == region && 
                    prog.Area == area && prog.Prognoz.Count != 0)
                {

                    for (int i = 0; i < prog.Prognoz.Count - 1; i++)
                    {
                        var days = db.Get_Date(prog.Prognoz[i].Date);
                        if (db.Get_Date(prog.Prognoz[i].Date).Month == db.Get_Date(prog.Prognoz[i + 1].Date).Month &&
                            i + 2 != prog.Prognoz.Count)
                        {
                            temp += prog.Prognoz[i].Temp;
                            wet += prog.Prognoz[i].Wet;
                            pressure += prog.Prognoz[i].Pressure;
                            osadki += prog.Prognoz[i].Osadki;
                            count++;
                        }
                        else
                        {
                            Prognoz prop = new Prognoz();
                            prop.Temp = Math.Round(temp / count, 2);
                            prop.Wet = Math.Round(wet / count, 2);
                            prop.Pressure = Math.Round(pressure / count, 2);
                            prop.Osadki = Math.Round(osadki / count, 2);
                            prop.Date = new string(prog.Prognoz[i].Date);

                            temp = wet = osadki = pressure = count = 0;
                            props.Add(prop);
                        }
                    }
                    
                }

            }
            return props;
        }

        public List<string> Get_Increment(bool monthChecked, string country, string region, string area, 
                                   DateTime firstTime, DateTime secondTime)
        {
         

            List<string> prop = new List<string>();

            double first_temp = 0,
                   first_wet = 0,
                   first_osadki = 0,
                   first_pressure = 0;


           double second_temp = 0,
                  second_wet = 0,
                  second_osadki = 0,
                  second_pressure = 0;


            int count1 = 0;
            int count2 = 0;

            foreach (var prog in db.ParseJSON())
            {
                if (prog.Country == country && prog.Region == region
                    && prog.Area == area && prog.Prognoz.Count != 0)
                {
                    
                    for (int i = 0; i < prog.Prognoz.Count; i++)
                    {
                        if (monthChecked)
                        {
                            if (firstTime.Date.Month == db.Get_Date(prog.Prognoz[i].Date).Month &&
                                firstTime.Date.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                            {
                                first_temp += prog.Prognoz[i].Temp;
                                first_wet = prog.Prognoz[i].Wet;
                                first_osadki = prog.Prognoz[i].Osadki;
                                first_pressure = prog.Prognoz[i].Pressure;
                                count1++;
                            }

                            if (secondTime.Date.Month == db.Get_Date(prog.Prognoz[i].Date).Month &&
                                secondTime.Date.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                            {
                                second_temp += prog.Prognoz[i].Temp;
                                second_wet = prog.Prognoz[i].Wet;
                                second_osadki = prog.Prognoz[i].Osadki;
                                second_pressure = prog.Prognoz[i].Pressure;
                                count2++;
                            }

                        }
                        else
                        {
                            if (firstTime.Date.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                            {
                                first_temp += prog.Prognoz[i].Temp;
                                first_wet = prog.Prognoz[i].Wet;
                                first_osadki = prog.Prognoz[i].Osadki;
                                first_pressure = prog.Prognoz[i].Pressure;
                                count1++;
                            }

                            if (secondTime.Date.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                            {
                                second_temp += prog.Prognoz[i].Temp;
                                second_wet = prog.Prognoz[i].Wet;
                                second_osadki = prog.Prognoz[i].Osadki;
                                second_pressure = prog.Prognoz[i].Pressure;
                                count2++;
                            }
                        }
                    }
                }

            }

            prop.Add(Math.Round((first_temp / count1) - (second_temp / count2), 2).ToString());
            prop.Add(Math.Round((first_wet / count1) - (second_wet / count2), 2).ToString());
            prop.Add(Math.Round((first_pressure / count1) - (second_pressure / count2), 2).ToString());
            prop.Add(Math.Round((first_osadki / count1) - (second_osadki / count2), 2).ToString());


            return prop;
        }

        public void AddRecord(DateTime time, string country,
                                string region, string area,
                                double temp, double pressure,
                                double wet, double osadki)
        {
           
            db.AddRecord(time, country, region, area,
                          temp, pressure, wet, osadki);
        }

        public bool AddLocation(string country, string region, string area)
        {
            if(db.AddLocation(country, region, area))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Prognoz ShowOneRecord(DateTime time, string country, string region, string area)
        {
            Prognoz prognoz = new Prognoz();

            foreach (var prog in db.ParseJSON())
            {
                if (prog.Country == country && prog.Region == region && prog.Area == area)
                {

                    for (int i = 0; i < prog.Prognoz.Count; i++)
                    {

                        if (time == db.Get_Date(prog.Prognoz[i].Date))
                        {
                            prognoz.Date = time.ToString();
                            prognoz.Temp = prog.Prognoz[i].Temp;
                            prognoz.Wet = prog.Prognoz[i].Wet;
                            prognoz.Pressure = prog.Prognoz[i].Pressure;
                            prognoz.Osadki = prog.Prognoz[i].Osadki;
                        }
                    }

                }

            }
            return prognoz;

        }

        public void EditRecord(DateTime time, string country,
                             string region, string area,
                             double temp, double pressure,
                             double wet, double osadki)
        {
            db.EditRecord(time, country, region, area,
                          temp, pressure, wet, osadki);
        }

        public List<Prognoz> ShowRecords(DateTime time, string country,
                                string region, string area)
        {
            List<Prognoz> prognozes = new List<Prognoz>();
            foreach (var prog in db.ParseJSON())
            {
                if (prog.Country == country && prog.Region == region && 
                    prog.Area == area && prog.Prognoz.Count != 0)
                {

                    for (int i = 0; i < prog.Prognoz.Count ; i++)
                    {

                        if (time.Day == db.Get_Date(prog.Prognoz[i].Date).Day &&
                            time.Month == db.Get_Date(prog.Prognoz[i].Date).Month &&
                            time.Year == db.Get_Date(prog.Prognoz[i].Date).Year)
                        {
                            prognozes.Add(prog.Prognoz[i]);
                        }
                    }

                }

            }
            return prognozes;
        }

        public void DeleteRecord(DateTime time, string country,
                       string region, string area)
        {
            db.DeleteRecord(time, country, region, area);
        }

        static void Main(string[] args)
        {

        }

    }
}
