
namespace Lab
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDB = new System.Windows.Forms.Button();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.buttonRain = new System.Windows.Forms.Button();
            this.buttonDesc = new System.Windows.Forms.Button();
            this.panelName = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelMenu.Controls.Add(this.buttonDB);
            this.panelMenu.Controls.Add(this.buttonInc);
            this.panelMenu.Controls.Add(this.buttonAvg);
            this.panelMenu.Controls.Add(this.buttonRain);
            this.panelMenu.Controls.Add(this.buttonDesc);
            this.panelMenu.Controls.Add(this.panelName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 558);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonDB
            // 
            this.buttonDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDB.FlatAppearance.BorderSize = 0;
            this.buttonDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDB.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDB.Image = global::Lab.Properties.Resources.database;
            this.buttonDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDB.Location = new System.Drawing.Point(0, 355);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDB.Size = new System.Drawing.Size(220, 75);
            this.buttonDB.TabIndex = 5;
            this.buttonDB.Text = "  Изменить БД";
            this.buttonDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDB.UseVisualStyleBackColor = false;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click_1);
            // 
            // buttonInc
            // 
            this.buttonInc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonInc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInc.FlatAppearance.BorderSize = 0;
            this.buttonInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInc.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInc.Image = global::Lab.Properties.Resources.increase;
            this.buttonInc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInc.Location = new System.Drawing.Point(0, 280);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonInc.Size = new System.Drawing.Size(220, 75);
            this.buttonInc.TabIndex = 4;
            this.buttonInc.Text = "  Инкремент";
            this.buttonInc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInc.UseVisualStyleBackColor = false;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click_1);
            // 
            // buttonAvg
            // 
            this.buttonAvg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonAvg.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAvg.FlatAppearance.BorderSize = 0;
            this.buttonAvg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAvg.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAvg.Image = global::Lab.Properties.Resources.average;
            this.buttonAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAvg.Location = new System.Drawing.Point(0, 205);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonAvg.Size = new System.Drawing.Size(220, 75);
            this.buttonAvg.TabIndex = 3;
            this.buttonAvg.Text = " Сред. показатели";
            this.buttonAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAvg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAvg.UseVisualStyleBackColor = false;
            this.buttonAvg.Click += new System.EventHandler(this.buttonAvg_Click_1);
            // 
            // buttonRain
            // 
            this.buttonRain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonRain.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRain.FlatAppearance.BorderSize = 0;
            this.buttonRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRain.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRain.Image = global::Lab.Properties.Resources.heavy_rain;
            this.buttonRain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRain.Location = new System.Drawing.Point(0, 130);
            this.buttonRain.Name = "buttonRain";
            this.buttonRain.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonRain.Size = new System.Drawing.Size(220, 75);
            this.buttonRain.TabIndex = 2;
            this.buttonRain.Text = "  Осадки";
            this.buttonRain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRain.UseVisualStyleBackColor = false;
            this.buttonRain.Click += new System.EventHandler(this.buttonRain_Click_1);
            // 
            // buttonDesc
            // 
            this.buttonDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDesc.FlatAppearance.BorderSize = 0;
            this.buttonDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesc.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDesc.Image = global::Lab.Properties.Resources.info__1_;
            this.buttonDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesc.Location = new System.Drawing.Point(0, 55);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDesc.Size = new System.Drawing.Size(220, 75);
            this.buttonDesc.TabIndex = 1;
            this.buttonDesc.Text = "  Описание";
            this.buttonDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDesc.UseVisualStyleBackColor = false;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click_1);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.Black;
            this.panelName.BackgroundImage = global::Lab.Properties.Resources.image_W8h0k;
            this.panelName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelName.Controls.Add(this.label);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(220, 55);
            this.panelName.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(59, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(138, 28);
            this.label.TabIndex = 0;
            this.label.Text = "Dark Wolves";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.IndianRed;
            this.panelTitle.Controls.Add(this.panel1);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(575, 55);
            this.panelTitle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 442);
            this.panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelTitle.Location = new System.Drawing.Point(16, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitle.Size = new System.Drawing.Size(172, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dark Wolves";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesk
            // 
            this.panelDesk.BackgroundImage = global::Lab.Properties.Resources.AtIKm5mabPo;
            this.panelDesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(220, 55);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(575, 503);
            this.panelDesk.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 558);
            this.Controls.Add(this.panelDesk);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meteo";
            this.panelMenu.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonRain;
        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesk;
        private System.Windows.Forms.Button buttonDB;
    }
}

