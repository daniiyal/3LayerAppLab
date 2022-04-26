using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab.Forms
{
    public partial class FormInc : Form
    {
        BusinessLogicClass bl = new BusinessLogicClass();
        public FormInc()
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

        void outToLog(string output)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
                richTextBox1.AppendText(output);
            else
                richTextBox1.AppendText(Environment.NewLine + output);

            richTextBox1.ScrollToCaret();
        }


        private void Get_Increment() {

            List<string> inc = new List<string>();

            inc = bl.Get_Increment(radioButtonMonth.Checked, comboBoxCountry.Text, 
                                                    comboBoxRegion.Text, comboBoxArea.Text,
                                                    dateTimePickerFirst.Value.Date, dateTimePickerSecond.Value.Date);

            var temp = inc[0];
            var wet =inc[1];
            var pressure = inc[2];
            var osadki = inc[3];


            outToLog("Разница между датами");
            outToLog($"Темп: {temp}");
            outToLog($"Осадки: {osadki}");
            outToLog($"Давление: {pressure}");
            outToLog($"Влажность: {wet}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Get_Increment();
        }

        private void Set_Date()
        {
            List<DateTime> dates = new List<DateTime>();

            dates = bl.Set_Date(comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);

            if (dates != null)
            {
                
                dateTimePickerFirst.MinDate = dates[0];
                dateTimePickerFirst.MaxDate = dates[1];

                dateTimePickerSecond.MinDate = dates[0];
                dateTimePickerSecond.MaxDate = dates[1];
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
    }
}
