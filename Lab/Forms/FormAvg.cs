
using BusinessLogic;
using System;
using System.Windows.Forms;
using System.Globalization;


namespace Lab.Forms
{

    public enum Months
    {
        noands,
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь,
    }
    public partial class FormAvg : Form
    {
        BusinessLogicClass bl = new BusinessLogicClass();
   
        public FormAvg()
        {
            InitializeComponent();
            AddtoBox();
           
        }


        private void AddtoBox()
        {
            Show_Countries();
            Show_Regions();
            Show_Areas();

        }

        private void Show_Countries()
        {
            foreach(var country in bl.Get_Countries())
            {
                comboBoxCountry.Items.Add(country);
            }
        }
        private void Show_Regions()
        {
            comboBoxRegion.Items.Clear();
            foreach (var region in bl.Get_Regions(comboBoxCountry.Text))
            {
                comboBoxRegion.Items.Add(region);
            }
        }
        private void Show_Areas()
        {
            comboBoxArea.Items.Clear();
            foreach (var area in bl.Get_Areas(comboBoxCountry.Text, comboBoxRegion.Text))
            {
                comboBoxArea.Items.Add(area);
            }
        }


        void outToLog(string output)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
                richTextBox1.AppendText(output);
            else
                richTextBox1.AppendText(Environment.NewLine + output);

            richTextBox1.ScrollToCaret();
        }

        private void Get_Average()
        {
            foreach (var prognoz in bl.Get_Average(comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text))
            {

                DateTime date = new DateTime();
                date = DateTime.ParseExact(prognoz.Date, "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture);
                outToLog($"{(Months)date.Month} {date.Year}");
                outToLog($"Темп: {prognoz.Temp}");
                outToLog($"Давление: {prognoz.Pressure}");
                outToLog($"Влажность: {prognoz.Wet}");
                outToLog($"Осадки: {prognoz.Osadki}");
                outToLog("===============");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; 
            Get_Average();

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Regions();
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Areas();
        }
    }
}
