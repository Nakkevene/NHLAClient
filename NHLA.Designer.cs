namespace NHLAClient
{
    partial class NHLA
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.laHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbTemp0 = new System.Windows.Forms.ProgressBar();
            this.laTemp0 = new System.Windows.Forms.Label();
            this.laTemp1 = new System.Windows.Forms.Label();
            this.pbTemp1 = new System.Windows.Forms.ProgressBar();
            this.laTemp2 = new System.Windows.Forms.Label();
            this.pbTemp2 = new System.Windows.Forms.ProgressBar();
            this.laTemp3 = new System.Windows.Forms.Label();
            this.pbTemp3 = new System.Windows.Forms.ProgressBar();
            this.btnSettings = new System.Windows.Forms.Button();
            this.TempUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.laHeader);
            this.pnHeader.Controls.Add(this.btnExit);
            this.pnHeader.Location = new System.Drawing.Point(1, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(429, 23);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            // 
            // laHeader
            // 
            this.laHeader.AutoSize = true;
            this.laHeader.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHeader.Location = new System.Drawing.Point(3, 4);
            this.laHeader.Name = "laHeader";
            this.laHeader.Size = new System.Drawing.Size(77, 15);
            this.laHeader.TabIndex = 1;
            this.laHeader.Text = "NHLAClient";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(394, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbTemp0
            // 
            this.pbTemp0.ForeColor = System.Drawing.Color.Crimson;
            this.pbTemp0.Location = new System.Drawing.Point(15, 48);
            this.pbTemp0.Name = "pbTemp0";
            this.pbTemp0.Size = new System.Drawing.Size(403, 16);
            this.pbTemp0.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbTemp0.TabIndex = 1;
            // 
            // laTemp0
            // 
            this.laTemp0.AutoSize = true;
            this.laTemp0.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTemp0.Location = new System.Drawing.Point(12, 30);
            this.laTemp0.Name = "laTemp0";
            this.laTemp0.Size = new System.Drawing.Size(42, 15);
            this.laTemp0.TabIndex = 2;
            this.laTemp0.Text = "temp0";
            // 
            // laTemp1
            // 
            this.laTemp1.AutoSize = true;
            this.laTemp1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTemp1.Location = new System.Drawing.Point(12, 70);
            this.laTemp1.Name = "laTemp1";
            this.laTemp1.Size = new System.Drawing.Size(42, 15);
            this.laTemp1.TabIndex = 4;
            this.laTemp1.Text = "temp1";
            // 
            // pbTemp1
            // 
            this.pbTemp1.ForeColor = System.Drawing.Color.Crimson;
            this.pbTemp1.Location = new System.Drawing.Point(15, 88);
            this.pbTemp1.Name = "pbTemp1";
            this.pbTemp1.Size = new System.Drawing.Size(403, 16);
            this.pbTemp1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbTemp1.TabIndex = 3;
            // 
            // laTemp2
            // 
            this.laTemp2.AutoSize = true;
            this.laTemp2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTemp2.Location = new System.Drawing.Point(12, 107);
            this.laTemp2.Name = "laTemp2";
            this.laTemp2.Size = new System.Drawing.Size(42, 15);
            this.laTemp2.TabIndex = 6;
            this.laTemp2.Text = "temp2";
            // 
            // pbTemp2
            // 
            this.pbTemp2.ForeColor = System.Drawing.Color.Crimson;
            this.pbTemp2.Location = new System.Drawing.Point(15, 125);
            this.pbTemp2.Name = "pbTemp2";
            this.pbTemp2.Size = new System.Drawing.Size(403, 16);
            this.pbTemp2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbTemp2.TabIndex = 5;
            // 
            // laTemp3
            // 
            this.laTemp3.AutoSize = true;
            this.laTemp3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTemp3.Location = new System.Drawing.Point(12, 144);
            this.laTemp3.Name = "laTemp3";
            this.laTemp3.Size = new System.Drawing.Size(42, 15);
            this.laTemp3.TabIndex = 8;
            this.laTemp3.Text = "temp3";
            // 
            // pbTemp3
            // 
            this.pbTemp3.ForeColor = System.Drawing.Color.Crimson;
            this.pbTemp3.Location = new System.Drawing.Point(15, 162);
            this.pbTemp3.Name = "pbTemp3";
            this.pbTemp3.Size = new System.Drawing.Size(403, 16);
            this.pbTemp3.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbTemp3.TabIndex = 7;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(15, 188);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(403, 23);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // TempUpdate
            // 
            this.TempUpdate.Interval = 5000;
            this.TempUpdate.Tick += new System.EventHandler(this.TempUpdate_Tick);
            // 
            // NHLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(430, 225);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.laTemp3);
            this.Controls.Add(this.pbTemp3);
            this.Controls.Add(this.laTemp2);
            this.Controls.Add(this.pbTemp2);
            this.Controls.Add(this.laTemp1);
            this.Controls.Add(this.pbTemp1);
            this.Controls.Add(this.laTemp0);
            this.Controls.Add(this.pbTemp0);
            this.Controls.Add(this.pnHeader);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NHLA";
            this.Text = "NHLA";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar pbTemp0;
        private System.Windows.Forms.Label laTemp0;
        private System.Windows.Forms.Label laTemp1;
        private System.Windows.Forms.ProgressBar pbTemp1;
        private System.Windows.Forms.Label laTemp2;
        private System.Windows.Forms.ProgressBar pbTemp2;
        private System.Windows.Forms.Label laTemp3;
        private System.Windows.Forms.ProgressBar pbTemp3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer TempUpdate;
        public System.Windows.Forms.Label laHeader;
    }
}

