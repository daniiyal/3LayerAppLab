using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab
{
    public partial class FormMainMenu : Form
    {
      

        private Button currButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currButton = (Button)btnSender;
                    currButton.BackColor = color;
                    currButton.ForeColor = Color.White;
                    currButton.Font = new Font("Segoe UI ", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control prevBtn in panelMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(32, 32, 32);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new Font("Segoe UI ", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            
            }
        }


        private void ChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesk.Controls.Add(childForm);
            panelDesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;

        }






        private void buttonDesc_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Forms.FormDesc(), sender);

        }

        private void buttonRain_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Forms.FormRain(), sender);
        }

        private void buttonAvg_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Forms.FormAvg(), sender);
        }

        private void buttonInc_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Forms.FormInc(), sender);
        }

        private void buttonDB_Click_1(object sender, EventArgs e)
        {
            ChildForm(new Forms.FormDB(), sender);
        }
    }
}
