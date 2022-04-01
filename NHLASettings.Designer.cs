namespace NHLAClient
{
    partial class NHLASettings
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.laHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Panel();
            this.laUpdate = new System.Windows.Forms.Label();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.laServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.d2 = new System.Windows.Forms.Panel();
            this.btnNeofetch = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pnHeader.SuspendLayout();
            this.d1.SuspendLayout();
            this.d2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.laHeader);
            this.pnHeader.Controls.Add(this.btnExit);
            this.pnHeader.Location = new System.Drawing.Point(-1, 1);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(362, 23);
            this.pnHeader.TabIndex = 1;
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            // 
            // laHeader
            // 
            this.laHeader.AutoSize = true;
            this.laHeader.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHeader.Location = new System.Drawing.Point(3, 4);
            this.laHeader.Name = "laHeader";
            this.laHeader.Size = new System.Drawing.Size(154, 15);
            this.laHeader.TabIndex = 1;
            this.laHeader.Text = "NHLAClient - Settings";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(326, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // d1
            // 
            this.d1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.d1.Controls.Add(this.laUpdate);
            this.d1.Controls.Add(this.tbUpdate);
            this.d1.Controls.Add(this.btnSave);
            this.d1.Controls.Add(this.laServer);
            this.d1.Controls.Add(this.tbServer);
            this.d1.Location = new System.Drawing.Point(12, 30);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(163, 170);
            this.d1.TabIndex = 2;
            // 
            // laUpdate
            // 
            this.laUpdate.AutoSize = true;
            this.laUpdate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUpdate.Location = new System.Drawing.Point(3, 40);
            this.laUpdate.Name = "laUpdate";
            this.laUpdate.Size = new System.Drawing.Size(126, 14);
            this.laUpdate.TabIndex = 4;
            this.laUpdate.Text = "Update rate (ms):";
            // 
            // tbUpdate
            // 
            this.tbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.tbUpdate.Location = new System.Drawing.Point(3, 57);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(153, 20);
            this.tbUpdate.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(3, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // laServer
            // 
            this.laServer.AutoSize = true;
            this.laServer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laServer.Location = new System.Drawing.Point(3, 0);
            this.laServer.Name = "laServer";
            this.laServer.Size = new System.Drawing.Size(56, 14);
            this.laServer.TabIndex = 1;
            this.laServer.Text = "Server:";
            // 
            // tbServer
            // 
            this.tbServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbServer.ForeColor = System.Drawing.Color.Crimson;
            this.tbServer.Location = new System.Drawing.Point(3, 17);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(153, 20);
            this.tbServer.TabIndex = 0;
            // 
            // d2
            // 
            this.d2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.d2.Controls.Add(this.btnNeofetch);
            this.d2.Controls.Add(this.rtbInfo);
            this.d2.Location = new System.Drawing.Point(186, 30);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(163, 170);
            this.d2.TabIndex = 3;
            // 
            // btnNeofetch
            // 
            this.btnNeofetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeofetch.Location = new System.Drawing.Point(3, 139);
            this.btnNeofetch.Name = "btnNeofetch";
            this.btnNeofetch.Size = new System.Drawing.Size(153, 23);
            this.btnNeofetch.TabIndex = 3;
            this.btnNeofetch.Text = "Neofetch";
            this.btnNeofetch.UseVisualStyleBackColor = true;
            this.btnNeofetch.Click += new System.EventHandler(this.btnNeofetch_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.rtbInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbInfo.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.ForeColor = System.Drawing.Color.Crimson;
            this.rtbInfo.Location = new System.Drawing.Point(3, 3);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(153, 130);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "NakkenHassuLämpötilaAsema\n\nxXPinkkiPoni96Xx / Apache-2.0\n\nhttps://github.com/xXPi" +
    "nkkiPoni96Xx/NHLA\n\nyo";
            // 
            // NHLASettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(361, 209);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.pnHeader);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NHLASettings";
            this.Text = "NHLASettings";
            this.VisibleChanged += new System.EventHandler(this.NHLASettings_VisibleChanged);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.d1.ResumeLayout(false);
            this.d1.PerformLayout();
            this.d2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label laHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel d1;
        private System.Windows.Forms.Panel d2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label laServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button btnNeofetch;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label laUpdate;
        private System.Windows.Forms.TextBox tbUpdate;
    }
}