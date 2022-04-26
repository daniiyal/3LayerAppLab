using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace Lab.Forms
{
    public partial class FormEdit : Form
    {
        BusinessLogicClass bl = new BusinessLogicClass();
        DateTime time;
        string country, region, area;
        public FormEdit(DateTime time, string country, string region, string area)
        {
            this.time = time;
            this.country = country;
            this.region = region;
            this.area = area;

            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
      
        }
        
        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }

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
        private void EditRecord()
        {

                bl.EditRecord(time, country, region, area,
                          Convert.ToDouble(richTextBoxTemp.Text),
                          Convert.ToDouble(richTextBoxPressure.Text),
                          Convert.ToDouble(richTextBoxWet.Text),
                          Convert.ToDouble(richTextBoxOsadki.Text));
   
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            EditRecord();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
