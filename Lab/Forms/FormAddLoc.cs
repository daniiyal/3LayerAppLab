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
    public partial class FormAddLoc : Form
    {
        BusinessLogicClass bl = new BusinessLogicClass();
        public FormAddLoc()
        {
            InitializeComponent();
            AddtoBox();
        }
        private void AddtoBox()
        {
            Show_Countries();
            Show_Regions();

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

        private void AddLocation()
        {
           if  (bl.AddLocation(comboBoxCountry.Text, comboBoxRegion.Text, textBox1.Text))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Такая локация уже существует");
            }
        }

        private void buttonAddLoc_Click(object sender, EventArgs e)
        {
            AddLocation();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
