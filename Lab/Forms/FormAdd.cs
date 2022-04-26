using BusinessLogic;
using System;
using System.Windows.Forms;

namespace Lab.Forms
{
    public partial class FormAdd : Form
    {
        BusinessLogicClass bl = new BusinessLogicClass();
        string country, region, area;
        public FormAdd(string country, string region, string area)
        {
            this.country = country;
            this.region = region;
            this.area = area;

            InitializeComponent();
        }


        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //цифры, клавиша BackSpace, минус и запятая а ASCII
            {
                e.Handled = true;
            }

        }

        private void AddRecord()
        {

             bl.AddRecord(dateTimePicker1.Value, country, region, area,
              Convert.ToDouble(richTextBoxTemp.Text),
              Convert.ToDouble(richTextBoxPressure.Text),
              Convert.ToDouble(richTextBoxWet.Text),
              Convert.ToDouble(richTextBoxOsadki.Text));

        }

        private void richTextBoxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void richTextBoxOsadki_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void richTextBoxWet_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void richTextBoxPressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckDigit(sender, e);
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            AddRecord();
            Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}