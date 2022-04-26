
namespace Lab.Forms
{
    partial class FormDB
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonAddRec = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddLoc = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(287, 55);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 45;
            this.dateTimePicker.Value = new System.DateTime(2021, 10, 20, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(287, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Выберите дату";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(287, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 117);
            this.panel3.TabIndex = 43;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 117);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel2.Controls.Add(this.comboBoxArea);
            this.panel2.Location = new System.Drawing.Point(23, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 52);
            this.panel2.TabIndex = 41;
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
            this.comboBoxArea.SelectedIndexChanged += new System.EventHandler(this.comboBoxArea_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "Выберите район";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel4.Controls.Add(this.comboBoxRegion);
            this.panel4.Location = new System.Drawing.Point(23, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 52);
            this.panel4.TabIndex = 39;
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
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "Выберите регион";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Выберите страну";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(23, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 58);
            this.button1.TabIndex = 37;
            this.button1.Text = "Отобразить БД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel1.Controls.Add(this.comboBoxCountry);
            this.panel1.Location = new System.Drawing.Point(23, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 52);
            this.panel1.TabIndex = 36;
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
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged_1);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.richTextBoxInfo);
            this.panelInfo.Location = new System.Drawing.Point(287, 261);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(250, 91);
            this.panelInfo.TabIndex = 46;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(250, 92);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonAddRec
            // 
            this.buttonAddRec.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAddRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddRec.FlatAppearance.BorderSize = 0;
            this.buttonAddRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRec.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddRec.Location = new System.Drawing.Point(287, 407);
            this.buttonAddRec.Name = "buttonAddRec";
            this.buttonAddRec.Size = new System.Drawing.Size(250, 35);
            this.buttonAddRec.TabIndex = 47;
            this.buttonAddRec.Text = "Добавить запись";
            this.buttonAddRec.UseVisualStyleBackColor = false;
            this.buttonAddRec.Click += new System.EventHandler(this.buttonAddRec_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDel.Location = new System.Drawing.Point(424, 366);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(113, 35);
            this.buttonDel.TabIndex = 50;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(287, 366);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(113, 35);
            this.buttonEdit.TabIndex = 51;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonAddLoc
            // 
            this.buttonAddLoc.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAddLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddLoc.FlatAppearance.BorderSize = 0;
            this.buttonAddLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLoc.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddLoc.Location = new System.Drawing.Point(287, 448);
            this.buttonAddLoc.Name = "buttonAddLoc";
            this.buttonAddLoc.Size = new System.Drawing.Size(250, 35);
            this.buttonAddLoc.TabIndex = 52;
            this.buttonAddLoc.Text = "Добавить локацию";
            this.buttonAddLoc.UseVisualStyleBackColor = false;
            this.buttonAddLoc.Click += new System.EventHandler(this.buttonAddLoc_Click);
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.ClientSize = new System.Drawing.Size(557, 498);
            this.Controls.Add(this.buttonAddLoc);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAddRec);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FormDB";
            this.Text = "Изменить БД";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
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
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonAddRec;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddLoc;
    }
}