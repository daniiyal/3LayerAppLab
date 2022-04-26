using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using BusinessLogic;
using System.Globalization;

namespace Lab.Forms
{
    public partial class FormDB : Form
    {
        BusinessLogicClass bl = new BusinessLogicClass();
        public FormDB()
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

        private void Set_Date()
        {
            List<DateTime> dates = new List<DateTime>();

            dates = bl.Set_Date(comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);

            if (dates != null)
            {

                dateTimePicker.MinDate = dates[0];
                dateTimePicker.MaxDate = dates[1];

            }

        }
        void listBox1_DoubleClick(object sender, MouseEventArgs e)

        {

            int index = listBox1.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)

            {
                MessageBox.Show(index.ToString());
                listBox1.ClearSelected();

            }
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxInfo.Text = "";
            string curItem = listBox1.SelectedItem.ToString();


            var prognoz = bl.ShowOneRecord(DateTime.ParseExact(curItem, "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture),
                                           comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);

            outToLog($"Дата: {prognoz.Date}");
            outToLog($"Температура: {prognoz.Temp}");
            outToLog($"Влажность: {prognoz.Wet}");
            outToLog($"Осадки: {prognoz.Osadki}");
            outToLog($"Давление: {prognoz.Pressure}");

        }


        private void ShowRecords()
        {
            listBox1.Items.Clear();
            var prognoz = bl.ShowRecords(dateTimePicker.Value, comboBoxCountry.Text,
                                         comboBoxRegion.Text, comboBoxArea.Text);
            for (int i = 0; i < prognoz.Count; i++)
            {
                listBox1.Items.Add(prognoz[i].Date);
                listBox1.DisplayMember = "prognoz[i].Date";
            }
              
            
        }
        void outToLog(string output)
        {
            if (String.IsNullOrEmpty(richTextBoxInfo.Text))
                richTextBoxInfo.AppendText(output);
            else
                richTextBoxInfo.AppendText(Environment.NewLine + output);

            richTextBoxInfo.ScrollToCaret();
        }

        private void comboBoxArea_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Set_Date();
            
        }

        private void comboBoxRegion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Set_Date();
            Show_Areas();
        }

        private void comboBoxCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Set_Date();
            Show_Regions();
        }



        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DateTime time = DateTime.ParseExact(listBox1.SelectedItem.ToString(), "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture);
                FormEdit formEdit = new FormEdit(time, comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);
                formEdit.Show();
            }
            else
            {
                MessageBox.Show("Выберите запись");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DialogResult res = MessageBox.Show("Уверены, что хотите удалить запись?", "Confirmation",
                                                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    DateTime time = DateTime.ParseExact(listBox1.SelectedItem.ToString(), "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture);
                    bl.DeleteRecord(time, comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись");
            }
        }

        private void buttonAddRec_Click(object sender, EventArgs e)
        {
            if (comboBoxCountry.Text != "" && comboBoxRegion.Text != "" && comboBoxArea.Text != "")
            {
                FormAdd form = new FormAdd(comboBoxCountry.Text, comboBoxRegion.Text, comboBoxArea.Text);
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowRecords();
        }

        private void buttonAddLoc_Click(object sender, EventArgs e)
        {
            FormAddLoc form = new FormAddLoc();
            form.Show();
        }
    }
}
