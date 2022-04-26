
namespace Lab.Forms
{
    partial class FormRain
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxInt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(276, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 58);
            this.panel3.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(269, 58);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel2.Controls.Add(this.comboBoxArea);
            this.panel2.Location = new System.Drawing.Point(17, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 52);
            this.panel2.TabIndex = 23;
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(0, 0);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(234, 28);
            this.comboBoxArea.TabIndex = 0;
            this.comboBoxArea.SelectedIndexChanged += new System.EventHandler(this.comboBoxArea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Выберите район";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel4.Controls.Add(this.comboBoxRegion);
            this.panel4.Location = new System.Drawing.Point(17, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 52);
            this.panel4.TabIndex = 21;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(0, 0);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(234, 28);
            this.comboBoxRegion.TabIndex = 0;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Выберите регион";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Выберите страну";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(17, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Отобразить результаты";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel1.Controls.Add(this.comboBoxCountry);
            this.panel1.Location = new System.Drawing.Point(17, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 52);
            this.panel1.TabIndex = 18;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(234, 28);
            this.comboBoxCountry.TabIndex = 0;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Menu;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(318, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 10, 25, 0, 0, 0, 0), new System.DateTime(2021, 10, 31, 0, 0, 0, 0));
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel5.Controls.Add(this.comboBoxInt);
            this.panel5.Location = new System.Drawing.Point(276, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 52);
            this.panel5.TabIndex = 25;
            // 
            // comboBoxInt
            // 
            this.comboBoxInt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInt.FormattingEnabled = true;
            this.comboBoxInt.Location = new System.Drawing.Point(0, 0);
            this.comboBoxInt.Name = "comboBoxInt";
            this.comboBoxInt.Size = new System.Drawing.Size(269, 28);
            this.comboBoxInt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(276, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Выберите интервал";
            // 
            // FormRain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.ClientSize = new System.Drawing.Size(557, 468);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FormRain";
            this.Text = "Осадки";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxInt;
        private System.Windows.Forms.Label label4;
    }
}