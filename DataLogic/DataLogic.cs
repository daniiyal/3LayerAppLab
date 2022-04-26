using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;

namespace DataLogic
{
    public class DataBase
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\prognoz.json";
        public List<Location> ParseJSON()
        {
           
            var data = File.ReadAllText(path);
            var prognoz = JsonSerializer.Deserialize<List<Location>>(data);
            return prognoz;
        }


        public DateTime Get_Date(string prognozDate)
        {

            var day = DateTime.ParseExact(prognozDate, "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture);

            return day;
        }


        public void EditRecord(DateTime time, string country,
                                string region, string area,
                                double temp, double pressure,
                                double wet, double osadki)
        {
            var prognoz = ParseJSON();
            foreach (var prog in prognoz)
            {
                if (prog.Country == country && prog.Region == region &&
                    prog.Area == area)
                {
                    for (int i = 0; i < prog.Prognoz.Count; i++)
                    {
                        if (time == DateTime.ParseExact(prog.Prognoz[i].Date, "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))
                        {
                            prog.Prognoz[i].Temp = temp;
                            prog.Prognoz[i].Pressure = pressure;
                            prog.Prognoz[i].Wet = wet;
                            prog.Prognoz[i].Osadki = osadki;
                            break;
                        }
                    }
                }

            }
            var json = JsonSerializer.Serialize<List<Location>>(prognoz);
            File.WriteAllText(path, json);
        }

        public void AddRecord(DateTime time, string country,
                                string region, string area,
                                double temp, double pressure,
                                double wet, double osadki)
        {

            
            var prognoz = ParseJSON();
            foreach (var prog in prognoz)
            {
                if (prog.Country == country && prog.Region == region &&
                    prog.Area == area)
                {
                    Prognoz newPrognoz = new Prognoz();
                    newPrognoz.Date = time.ToString("dd.MM.yyyy H:mm", CultureInfo.InvariantCulture);
                    newPrognoz.Temp = temp;
                    newPrognoz.Osadki = osadki;
                    newPrognoz.Wet = wet;
                    newPrognoz.Pressure = pressure;

                    prog.Prognoz.Add(newPrognoz);
                                    
                }

            }
            var json = JsonSerializer.Serialize<List<Location>>(prognoz);
            File.WriteAllText(path, json);
        }

        public void DeleteRecord(DateTime time, string country,
                        string region, string area)
        {
            var prognoz = ParseJSON();
            foreach (var prog in prognoz)
            {
                if (prog.Country == country && prog.Region == region &&
                    prog.Area == area)
                {
                    for (int i = 0; i < prog.Prognoz.Count; i++)
                    {
                        if (time == Get_Date(prog.Prognoz[i].Date))
                        {
                            prog.Prognoz.RemoveAt(i);
                            break;
                        }
                    }
                }

            }
            var json = JsonSerializer.Serialize<List<Location>>(prognoz);
            File.WriteAllText(path, json);
        }

        public bool AddLocation(string country, string region, string area)
        {
           
            var prognoz = ParseJSON();
            foreach (var prog in prognoz)
            {
                if (prog.Country == country && prog.Region == region && prog.Area == area)
                {
                    return false;
                }

            }
            Location newLocation = new Location();
            newLocation.Country = country;
            newLocation.Region = region;
            newLocation.Area = area;
            newLocation.Prognoz = new List<Prognoz>();
           
            
            prognoz.Add(newLocation);
            var json = JsonSerializer.Serialize<List<Location>>(prognoz);
            File.WriteAllText(path, json);
            return true;
        }

        static void Main(string[] args)
        {

        }
    }
}
