namespace clock
{
    partial class frmClock
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chkSayTime = new System.Windows.Forms.CheckBox();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.cboxInterval = new System.Windows.Forms.ComboBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(196, 82);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 40);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chkSayTime
            // 
            this.chkSayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSayTime.AutoSize = true;
            this.chkSayTime.Checked = true;
            this.chkSayTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSayTime.ForeColor = System.Drawing.Color.White;
            this.chkSayTime.Location = new System.Drawing.Point(26, 141);
            this.chkSayTime.Name = "chkSayTime";
            this.chkSayTime.Size = new System.Drawing.Size(100, 24);
            this.chkSayTime.TabIndex = 2;
            this.chkSayTime.Text = "Say Time";
            this.chkSayTime.UseVisualStyleBackColor = true;
            // 
            // chkOnTop
            // 
            this.chkOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.ForeColor = System.Drawing.Color.White;
            this.chkOnTop.Location = new System.Drawing.Point(168, 141);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(87, 24);
            this.chkOnTop.TabIndex = 3;
            this.chkOnTop.Text = "On Top";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // btnListen
            // 
            this.btnListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListen.Location = new System.Drawing.Point(506, 129);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(101, 35);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // cboxInterval
            // 
            this.cboxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxInterval.FormattingEnabled = true;
            this.cboxInterval.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "15",
            "30",
            "45",
            "60"});
            this.cboxInterval.Location = new System.Drawing.Point(377, 136);
            this.cboxInterval.Name = "cboxInterval";
            this.cboxInterval.Size = new System.Drawing.Size(91, 28);
            this.cboxInterval.TabIndex = 5;
            // 
            // lblInterval
            // 
            this.lblInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterval.AutoSize = true;
            this.lblInterval.ForeColor = System.Drawing.Color.White;
            this.lblInterval.Location = new System.Drawing.Point(310, 141);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(61, 20);
            this.lblInterval.TabIndex = 6;
            this.lblInterval.Text = "Interval";
            // 
            // btnClipboard
            // 
            this.btnClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipboard.Location = new System.Drawing.Point(506, 91);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(101, 35);
            this.btnClipboard.TabIndex = 7;
            this.btnClipboard.Text = "Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(610, 177);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.cboxInterval);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.chkOnTop);
            this.Controls.Add(this.chkSayTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Name = "frmClock";
            this.Text = "Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox chkSayTime;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ComboBox cboxInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Button btnClipboard;
    }
}

