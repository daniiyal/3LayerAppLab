using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using BusinessLogic;

namespace Lab.Forms

{
    public partial class FormRain : Form
    {

        BusinessLogicClass bl = new BusinessLogicClass();
        public FormRain()
        {
            InitializeComponent();
            AddtoBox();
        }
        private void AddtoBox()
        {
            Set_Interval();
            Show_Countries();
            Show_Regions();
            Show_Areas();

        }
        private void Show_Countries()
        {
            comboBoxCountry.Items.Clear();
            foreach (var country in bl.Get_Countries())
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
        private void Set_Interval()
        {
            comboBoxInt.Items.Add("День");
            comboBoxInt.Items.Add("Неделя");
            comboBoxInt.Items.Add("Месяц");
            comboBoxInt.Items.Add("Год");
        }


        
        void outToLog(string output)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
                richTextBox1.AppendText(output);
            else
                richTextBox1.AppendText(Environment.NewLine + output);

            richTextBox1.ScrollToCaret();
        }

        private void Set_Date()
        {
            List<DateTime> dates = new List<DateTime>();

            dates = bl.Set_Date(comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);

            if (dates != null)
            {
                monthCalendar1.MinDate = dates[0];
                monthCalendar1.MaxDate = dates[1];
                
                monthCalendar1.MaxSelectionCount = 1;
            }


           
        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_Date();
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_Date();
            Show_Areas();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_Date();
            Show_Regions();
        }

        private void Get_Rain() {
            double rain = bl.Get_Rain(monthCalendar1.SelectionStart, comboBoxInt.Text,
                                      comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);
            outToLog("Осадки за выбранный интервал");
            outToLog($"{rain}");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Get_Rain();
        }
    }

}
