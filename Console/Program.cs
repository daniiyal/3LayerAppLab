using System;
using System.Collections.Generic;
using System.Globalization;

namespace Console
{
    class Program
    {
        static double DoubleCheck()
        {
            string num;
            double h = 0;
            do
            {
                num = System.Console.ReadLine();
                bool success = Double.TryParse(num, out h);
                if (success && h > 0)
                {
                    return h;
                }
                System.Console.Write("\t\tInvalid symbol, try again with numbers\n\t\t");
            } while (true);
        }
        static int IntCheck()
        {
            string num;
            int h = 0;
            do
            {
                num = System.Console.ReadLine();
                bool success = int.TryParse(num, out h);
                if (success && h > 0)
                {
                    return h;
                }
                System.Console.Write("\t\tInvalid symbol, try again with numbers\n\t\t");
            } while (true);
        }
        static void tabl(int lenght)
        {
            int now = ((4 * 7) - lenght) / 7;
            for (int i = 0; i < now + 1; i++)
                System.Console.Write("\t");
        }
        static void Menu_Print()
        {
            System.Console.WriteLine("\t\t_________________________________________________________________");
            System.Console.WriteLine("\t\t|Возможные функции:\t\t|\tКлавиши на клавиатуре:\t|");
            System.Console.WriteLine("\t\t|-------------------------------|-------------------------------|");
            System.Console.WriteLine("\t\t|Осадки\t\t\t\t|\t1\t\t\t|");
            System.Console.WriteLine("\t\t|Средние показатели\t\t|\t2\t\t\t|");
            System.Console.WriteLine("\t\t|Инкремент\t\t\t|\t3\t\t\t|");
            System.Console.WriteLine("\t\t|Добавить\t\t\t|\t4\t\t\t|");
            System.Console.WriteLine("\t\t|Изменить\t\t\t|\t5\t\t\t|");
            System.Console.WriteLine("\t\t|Удалить\t\t\t|\t6\t\t\t|");
            System.Console.WriteLine("\t\t|Выход\t\t\t\t|\t9\t\t\t|");
            System.Console.WriteLine("\t\t|_______________________________________________________________|");
            System.Console.Write("\n\n\t\tВыберите: ");
        }
        static string Country_Choose(IEnumerable<string> ie)
        {
            int choose;
            System.Console.WriteLine("\t\t_________________________________________________________________");
            System.Console.WriteLine("\t\t|Выберите страну\t\t|\tКлавиши на клавиатуре:\t|");
            System.Console.WriteLine("\t\t|-------------------------------|-------------------------------|");
            int i = 1;
            foreach (var p in ie)
            {
                System.Console.Write("\t\t|");
                System.Console.Write(p.ToString());
                tabl((p.ToString()).Length);
                System.Console.Write("|\t" + i + "\t\t\t|\n");
                i++;
            }
            System.Console.WriteLine("\t\t|_______________________________________________________________|");
            System.Console.Write("\n\n\t\tВыберите: ");
            do
            {
                choose = IntCheck();
                i = 1;
                foreach (var p in ie)
                {
                    if (choose == i)
                        return p.ToString();
                    i++;
                }
                System.Console.Write("\t\tСтраны с такой цифрой не существует\n\t\t");
            } while (true);
        }
        static string Region_Choose(IEnumerable<string> ie)
        {
            int choose;
            System.Console.WriteLine("\t\t_________________________________________________________________");
            System.Console.WriteLine("\t\t|Выберите регион\t\t|\tКлавиши на клавиатуре:\t|");
            System.Console.WriteLine("\t\t|-------------------------------|-------------------------------|");
            int i = 1;
            foreach (var p in ie)
            {
                System.Console.Write("\t\t|");
                System.Console.Write(p.ToString());
                tabl((p.ToString()).Length);
                System.Console.Write("|\t" + i + "\t\t\t|\n");
                i++;
            }
            System.Console.WriteLine("\t\t|_______________________________________________________________|");
            System.Console.Write("\n\n\t\tВыберите: ");
            do
            {
                choose = IntCheck();
                i = 1;
                foreach (var p in ie)
                {
                    if (choose == i)
                        return p.ToString();
                    i++;
                }
                System.Console.Write("\t\tРегиона с такой цифрой не существует\n\t\t");
            } while (true);
        }
        static string Area_Choose(IEnumerable<string> ie)
        {
            int choose;
            System.Console.WriteLine("\t\t_________________________________________________________________");
            System.Console.WriteLine("\t\t|Выберите город\t\t\t|\tКлавиши на клавиатуре:\t|");
            System.Console.WriteLine("\t\t|-------------------------------|-------------------------------|");
            int i = 1;
            foreach (var p in ie)
            {
                System.Console.Write("\t\t|");
                System.Console.Write(p.ToString());
                tabl((p.ToString()).Length);
                System.Console.Write("|\t" + i + "\t\t\t|\n");
                i++;
            }
            System.Console.WriteLine("\t\t|_______________________________________________________________|");
            System.Console.Write("\n\n\t\tВыберите: ");
            do
            {
                choose = IntCheck();
                i = 1;
                foreach (var p in ie)
                {
                    if (choose == i)
                        return p.ToString();
                    i++;
                }
                System.Console.WriteLine("\t\tГорода с такой цифрой не существует");
            } while (true);
        }
        static string Interval_Choose()
        {
            int choose;
            List<string> interval = new List<string>() { "День", "Неделя", "Месяц", "Год" };
            System.Console.WriteLine("\t\t_________________________________________________________________");
            System.Console.WriteLine("\t\t|Выберите интервал\t\t|\tКлавиши на клавиатуре:\t|");
            System.Console.WriteLine("\t\t|-------------------------------|-------------------------------|");
            int i = 1;
            foreach (string p in interval)
            {
                System.Console.Write("\t\t|");
                System.Console.Write(p);
                tabl(p.Length);
                System.Console.Write("|\t" + i + "\t\t\t|\n");
                i++;
            }
            System.Console.WriteLine("\t\t|_______________________________________________________________|");
            System.Console.Write("\n\n\t\tВыберите: ");
            do
            {
                choose = IntCheck();
                i = 1;
                foreach (string p in interval)
                {
                    if (choose == i)
                        return p;
                    i++;
                }
                System.Console.WriteLine("\t\tИнтервала с такой цифрой не существует");
            } while (true);
        }
        static int Year_Choose(List<DateTime> date)
        {
            int choose;
            do
            {
                System.Console.WriteLine($"\t\tКрайние даты {date[0].ToString("dd/MM/yyyy")} - {date[1].ToString("dd/MM/yyyy")}");
                System.Console.Write("\t\tНапишите год: ");
                do
                {
                    choose = IntCheck();
                    if (choose >= 1 && choose <= 9999)
                        break;
                    System.Console.Write("\t\tError Date\n\t\t");
                } while (true);
                if (date[0].Year <= choose && date[1].Year >= choose)
                {
                    return choose;
                }
                System.Console.WriteLine("\t\tError Date\n\t\t");
            } while (true);
        }
        static int Month_Choose(List<DateTime> date, int year)
        {
            int choose;
            DateTime up, low;
            do
            {
                System.Console.WriteLine($"\t\tКрайние даты {date[0].ToString("dd/MM/yyyy")} - {date[1].ToString("dd/MM/yyyy")}");
                System.Console.Write("\t\tНапишите месяц: ");
                do
                {
                    choose = IntCheck();
                    if (choose >= 1 && choose <= 12)
                        break;
                    System.Console.Write("\t\tError Date\n\t\t");
                } while (true);
                low = new DateTime(year, choose, date[1].Day);
                up = new DateTime(year, choose, date[0].Day);
                if (date[0] <= low && date[1] >= up)
                {
                    return choose;
                }
                System.Console.WriteLine("\t\tError Date");
            } while (true);
        }
        static int Day_Choose(List<DateTime> date, int year, int month)
        {
            int choose;
            DateTime now;
            do
            {
                System.Console.WriteLine($"\t\tКрайние даты {date[0].ToString("dd/MM/yyyy")} - {date[1].ToString("dd/MM/yyyy")}");
                System.Console.Write("\t\tНапишите день: ");
                choose = IntCheck();
                now = new DateTime(year, month, choose);
                if (date[0] <= now && date[1] >= now)
                {
                    return choose;
                }
                System.Console.WriteLine("\t\tError Date");
            } while (true);
        }
        static void Osadki()
        {
            var bl = new BusinessLogic.BusinessLogicClass();

            //Страна
            IEnumerable<string> ie = bl.Get_Countries();
            string country = Country_Choose(ie);

            //Регион
            ie = bl.Get_Regions(country);
            string region = Region_Choose(ie);

            //Город
            ie = bl.Get_Areas(country, region);
            string area = Area_Choose(ie);

            //Интервал
            string interval = Interval_Choose();

            int year = 2018;
            int month = 10;
            int day = 20;

            List<DateTime> date = bl.Set_Date(country, region, area);
            year = Year_Choose(date);
            if (interval != "Год")
                month = Month_Choose(date, year);
            if (interval != "Месяц" && interval != "Год")
                day = Day_Choose(date, year, month);
            DateTime now = new DateTime(year, month, day);
            System.Console.WriteLine("\t\tКоличество осадков = " + bl.Get_Rain(now, interval, country, region, area));
        }

        static void Srednee()
        {
            var bl = new BusinessLogic.BusinessLogicClass();

            //Страна
            IEnumerable<string> ie = bl.Get_Countries();
            string country = Country_Choose(ie);

            //Регион
            ie = bl.Get_Regions(country);
            string region = Region_Choose(ie);

            //Город
            ie = bl.Get_Areas(country, region);
            string area = Area_Choose(ie);

            foreach (var prognoz in bl.Get_Average(country, region, area))
            {
                DateTime date = new DateTime();
                date = DateTime.ParseExact(prognoz.Date, "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture);
                System.Console.WriteLine($"Месяц { date.Month}, Год {date.Year}");
                System.Console.WriteLine($"Температура: {prognoz.Temp}");
                System.Console.WriteLine($"Давление: {prognoz.Pressure}");
                System.Console.WriteLine($"Влажность: {prognoz.Wet}");
                System.Console.WriteLine($"Осдаки: {prognoz.Osadki}\n");
            }
        }

        static void Increment()
        {
            var bl = new BusinessLogic.BusinessLogicClass();
            bool monthChecked = true; //false - год       true - месяц

            //Страна
            IEnumerable<string> ie = bl.Get_Countries();
            string country = Country_Choose(ie);

            //Регион
            ie = bl.Get_Regions(country);
            string region = Region_Choose(ie);

            //Город
            ie = bl.Get_Areas(country, region);
            string area = Area_Choose(ie);

            System.Console.Write("\t\tВы хотите сравнить месяца или года?" +
                "\n\t\t1 = Месяца\t\t\tОстальные цифры = Года\n\t\t");
            int choose = IntCheck();
            if (choose != 1)
                monthChecked = false;
            int year = 2018;
            int month = 01;

            List<DateTime> date = bl.Set_Date(country, region, area);
            System.Console.WriteLine("\t\tВыберите первую дату:");
            year = Year_Choose(date);
            if (monthChecked)
                month = Month_Choose(date, year);
            DateTime now1 = new DateTime(year, month, 1);
            System.Console.WriteLine("\n\t\tВыберите вторую дату:");
            year = Year_Choose(date);
            if (monthChecked)
                month = Month_Choose(date, year);
            DateTime now2 = new DateTime(year, month, 1);

            var inc = bl.Get_Increment(monthChecked, country, region, area, now1, now2);
            System.Console.WriteLine("\n\t\tРазница между датами:");
            System.Console.WriteLine($"\t\tТемпература: {inc[0]}");
            System.Console.WriteLine($"\t\tОсадки: {inc[3]}");
            System.Console.WriteLine($"\t\tВлажность: {inc[1]}");
            System.Console.WriteLine($"\t\tДавление: {inc[2]}");
        }

        static void AddElement()
        {
            string addcountry;
            string addregion;
            string addarea;
            double addtemp;
            double addpressure;
            double addwet;
            double addosadki;

            var bl = new BusinessLogic.BusinessLogicClass();

            System.Console.WriteLine("\t\tВведите данные новой записи:");
            System.Console.WriteLine("\t\tСтрана: ");
            addcountry = System.Console.ReadLine();
            System.Console.WriteLine("\t\tРегион: ");
            addregion = System.Console.ReadLine();
            System.Console.WriteLine("\t\tОбласть: ");
            addarea = System.Console.ReadLine();
            System.Console.WriteLine("\t\tТемпература: ");
            addtemp = DoubleCheck();
            System.Console.WriteLine("\t\tДавление: ");
            addpressure = DoubleCheck();
            System.Console.WriteLine("\t\tВлажность: ");
            addwet = DoubleCheck();
            System.Console.WriteLine("\t\tОсадки: "); ;
            addosadki = DoubleCheck();

            int year, month, day, hours, minutes;
            System.Console.WriteLine("\t\tВведите год: ");
            year = IntCheck();
            System.Console.WriteLine("\t\tВведите месяц: ");
            month = IntCheck();
            System.Console.WriteLine("\t\tВведите день: ");
            day = IntCheck();
            System.Console.WriteLine("\t\tВведите час: ");
            hours = IntCheck();
            System.Console.WriteLine("\t\tВведите минуты: ");
            minutes = IntCheck();
            DateTime date = new DateTime(year, month, day, hours, minutes, 00);

            bl.AddRecord(date, addcountry, addregion, addarea, addtemp, addpressure, addwet, addosadki);
        }

        static void EditElement()
        {
            string editcountry;
            string editregion;
            string editarea;
            double edittemp;
            double editpressure;
            double editwet;
            double editosadki;

            var bl = new BusinessLogic.BusinessLogicClass();

            System.Console.WriteLine("\t\tВведите данные редактируемой записи:");
            System.Console.WriteLine("\t\tСтрана: ");
            editcountry = System.Console.ReadLine();
            System.Console.WriteLine("\t\tРегион: ");
            editregion = System.Console.ReadLine();
            System.Console.WriteLine("\t\tОбласть: ");
            editarea = System.Console.ReadLine();
            System.Console.WriteLine("\t\tТемпература: ");
            edittemp = DoubleCheck();
            System.Console.WriteLine("\t\tДавление: ");
            editpressure = DoubleCheck();
            System.Console.WriteLine("\t\tВлажность: ");
            editwet = DoubleCheck();
            System.Console.WriteLine("\t\tОсадки: ");
            editosadki = DoubleCheck();

            int year, month, day, hours, minutes;
            System.Console.WriteLine("\t\tВведите год: ");
            year = IntCheck();
            System.Console.WriteLine("\t\tВведите месяц: ");
            month = IntCheck();
            System.Console.WriteLine("\t\tВведите день: ");
            day = IntCheck();
            System.Console.WriteLine("\t\tВведите час: ");
            hours = IntCheck();
            System.Console.WriteLine("\t\tВведите минуты: ");
            minutes = IntCheck();
            DateTime date = new DateTime(year, month, day, hours, minutes, 00);

            bl.EditRecord(date, editcountry, editregion, editarea, edittemp, editpressure, editwet, editosadki);
        }

        static void DeleteElement()
        {
            string deletecountry;
            string deleteregion;
            string deletearea;

            var bl = new BusinessLogic.BusinessLogicClass();

            System.Console.WriteLine("\t\tВведите данные удаляемой записи:");
            System.Console.WriteLine("\t\tСтрана: ");
            deletecountry = System.Console.ReadLine();
            System.Console.WriteLine("\t\tРегион: ");
            deleteregion = System.Console.ReadLine();
            System.Console.WriteLine("\t\tОбласть: ");
            deletearea = System.Console.ReadLine();

            int year, month, day, hours, minutes;
            System.Console.WriteLine("\t\tВведите год: ");
            year = IntCheck();
            System.Console.WriteLine("\t\tВведите месяц: ");
            month = IntCheck();
            System.Console.WriteLine("\t\tВведите день: ");
            day = IntCheck();
            System.Console.WriteLine("\t\tВведите час: ");
            hours = IntCheck();
            System.Console.WriteLine("\t\tВведите минуты: ");
            minutes = IntCheck();
            DateTime date = new DateTime(year, month, day, hours, minutes, 00);

            bl.DeleteRecord(date, deletecountry, deleteregion, deletearea);
        }

        static void Main(string[] args)
        {
            bool exit = true;
            int choose;
            do
            {
                Menu_Print();
                choose = IntCheck();
                switch (choose)
                {
                    case 9:
                        exit = false;
                        break;
                    case 1:
                        Osadki();
                        break;
                    case 2:
                        Srednee();
                        break;
                    case 3:
                        Increment();
                        break;
                    case 4:
                        AddElement();
                        break;
                    case 5:
                        EditElement();
                        break;
                    case 6:
                        DeleteElement();
                        break;
                    default:
                        System.Console.WriteLine("\t\tВозможности с такой цифрой не существует");
                        choose = 0;
                        break;
                }
            } while (exit);
        }
    }
}