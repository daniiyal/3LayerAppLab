
namespace Lab.Forms
{
    partial class FormAddLoc
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddLoc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(42, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 52);
            this.panel2.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "Введите район";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel4.Controls.Add(this.comboBoxRegion);
            this.panel4.Location = new System.Drawing.Point(42, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 52);
            this.panel4.TabIndex = 46;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "Введите регион";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Введите страну";
            // 
            // buttonAddLoc
            // 
            this.buttonAddLoc.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAddLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddLoc.FlatAppearance.BorderSize = 0;
            this.buttonAddLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLoc.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddLoc.Location = new System.Drawing.Point(42, 369);
            this.buttonAddLoc.Name = "buttonAddLoc";
            this.buttonAddLoc.Size = new System.Drawing.Size(108, 41);
            this.buttonAddLoc.TabIndex = 44;
            this.buttonAddLoc.Text = "Добавить";
            this.buttonAddLoc.UseVisualStyleBackColor = false;
            this.buttonAddLoc.Click += new System.EventHandler(this.buttonAddLoc_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.panel1.Controls.Add(this.comboBoxCountry);
            this.panel1.Location = new System.Drawing.Point(42, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 52);
            this.panel1.TabIndex = 43;
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
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(168, 369);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 41);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab.Properties.Resources.gradient_bright_1757613;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddLoc);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddLoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddLoc";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddLoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCancel;
    }
}