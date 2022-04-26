
namespace Lab.Forms
{
    partial class FormInc
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
            this.components = new System.ComponentModel.Container();
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(273, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 145);
            this.panel3.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(269, 145);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel2.Controls.Add(this.comboBoxArea);
            this.panel2.Location = new System.Drawing.Point(14, 275);
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
            this.label3.Location = new System.Drawing.Point(14, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Выберите район";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel4.Controls.Add(this.comboBoxRegion);
            this.panel4.Location = new System.Drawing.Point(14, 172);
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
            this.label2.Location = new System.Drawing.Point(14, 138);
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
            this.label1.Location = new System.Drawing.Point(14, 34);
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
            this.button1.Location = new System.Drawing.Point(14, 362);
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
            this.panel1.Location = new System.Drawing.Point(14, 68);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(273, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Выберите сравниваемые даты";
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Location = new System.Drawing.Point(273, 69);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFirst.TabIndex = 31;
            this.dateTimePickerFirst.Value = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            // 
            // dateTimePickerSecond
            // 
            this.dateTimePickerSecond.Location = new System.Drawing.Point(273, 173);
            this.dateTimePickerSecond.Name = "dateTimePickerSecond";
            this.dateTimePickerSecond.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerSecond.TabIndex = 32;
            this.dateTimePickerSecond.Value = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonMonth.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.radioButtonMonth.Checked = true;
            this.radioButtonMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMonth.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMonth.Location = new System.Drawing.Point(273, 224);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(88, 29);
            this.radioButtonMonth.TabIndex = 34;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "Месяц";
            this.radioButtonMonth.UseVisualStyleBackColor = false;
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.radioButtonYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonYear.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonYear.Location = new System.Drawing.Point(367, 224);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(63, 29);
            this.radioButtonYear.TabIndex = 35;
            this.radioButtonYear.Text = "Год";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            // 
            // FormInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.ClientSize = new System.Drawing.Size(557, 468);
            this.Controls.Add(this.radioButtonYear);
            this.Controls.Add(this.radioButtonMonth);
            this.Controls.Add(this.dateTimePickerSecond);
            this.Controls.Add(this.dateTimePickerFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FormInc";
            this.Text = "Инкремент";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonYear;
    }
}