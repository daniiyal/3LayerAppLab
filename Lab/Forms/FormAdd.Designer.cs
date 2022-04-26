
namespace Lab.Forms
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBoxPressure = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBoxWet = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxOsadki = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxTemp = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(250, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 29);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(127, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 29);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Давление";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBoxPressure);
            this.panel4.Location = new System.Drawing.Point(223, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 28);
            this.panel4.TabIndex = 21;
            // 
            // richTextBoxPressure
            // 
            this.richTextBoxPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPressure.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxPressure.Name = "richTextBoxPressure";
            this.richTextBoxPressure.Size = new System.Drawing.Size(169, 28);
            this.richTextBoxPressure.TabIndex = 0;
            this.richTextBoxPressure.Text = "";
            this.richTextBoxPressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxPressure_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Влажность";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBoxWet);
            this.panel3.Location = new System.Drawing.Point(223, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 28);
            this.panel3.TabIndex = 19;
            // 
            // richTextBoxWet
            // 
            this.richTextBoxWet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxWet.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxWet.Name = "richTextBoxWet";
            this.richTextBoxWet.Size = new System.Drawing.Size(169, 28);
            this.richTextBoxWet.TabIndex = 0;
            this.richTextBoxWet.Text = "";
            this.richTextBoxWet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxWet_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Осадки";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBoxOsadki);
            this.panel2.Location = new System.Drawing.Point(223, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 28);
            this.panel2.TabIndex = 17;
            // 
            // richTextBoxOsadki
            // 
            this.richTextBoxOsadki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOsadki.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxOsadki.Name = "richTextBoxOsadki";
            this.richTextBoxOsadki.Size = new System.Drawing.Size(169, 28);
            this.richTextBoxOsadki.TabIndex = 0;
            this.richTextBoxOsadki.Text = "";
            this.richTextBoxOsadki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxOsadki_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Температура";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxTemp);
            this.panel1.Location = new System.Drawing.Point(223, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 28);
            this.panel1.TabIndex = 15;
            // 
            // richTextBoxTemp
            // 
            this.richTextBoxTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTemp.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxTemp.Name = "richTextBoxTemp";
            this.richTextBoxTemp.Size = new System.Drawing.Size(169, 28);
            this.richTextBoxTemp.TabIndex = 0;
            this.richTextBoxTemp.Text = "";
            this.richTextBoxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxTemp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 27);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // FormAdd
            // 
            this.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.ClientSize = new System.Drawing.Size(442, 386);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdd";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBoxPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBoxWet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxOsadki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}