namespace TimerApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Invert = new System.Windows.Forms.CheckBox();
            this.SetMode = new System.Windows.Forms.ComboBox();
            this.TimeSet = new System.Windows.Forms.ComboBox();
            this.SpeedSet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Less = new System.Windows.Forms.Button();
            this.More = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.HH = new System.Windows.Forms.TextBox();
            this.mm = new System.Windows.Forms.TextBox();
            this.ss = new System.Windows.Forms.TextBox();
            this.ff = new System.Windows.Forms.TextBox();
            this.Set = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAct
            // 
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAct.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAct.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnAct.Location = new System.Drawing.Point(66, 68);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(46, 69);
            this.btnAct.TabIndex = 0;
            this.btnAct.Text = ">";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.LightCoral;
            this.btnReset.Location = new System.Drawing.Point(118, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(42, 69);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "X";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Location = new System.Drawing.Point(480, 33);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(131, 29);
            this.Show.TabIndex = 2;
            this.Show.Text = "Show Timer";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.CheckedChanged += new System.EventHandler(this.Show_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Invert
            // 
            this.Invert.AutoSize = true;
            this.Invert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Invert.Location = new System.Drawing.Point(332, 33);
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(113, 29);
            this.Invert.TabIndex = 4;
            this.Invert.Text = "Inver time";
            this.Invert.UseVisualStyleBackColor = true;
            this.Invert.CheckedChanged += new System.EventHandler(this.Invert_CheckedChanged);
            // 
            // SetMode
            // 
            this.SetMode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SetMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetMode.FormattingEnabled = true;
            this.SetMode.Location = new System.Drawing.Point(61, 172);
            this.SetMode.Name = "SetMode";
            this.SetMode.Size = new System.Drawing.Size(105, 33);
            this.SetMode.TabIndex = 5;
            this.SetMode.SelectedIndexChanged += new System.EventHandler(this.SetMode_SelectedIndexChanged);
            // 
            // TimeSet
            // 
            this.TimeSet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TimeSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimeSet.FormattingEnabled = true;
            this.TimeSet.Location = new System.Drawing.Point(181, 172);
            this.TimeSet.Name = "TimeSet";
            this.TimeSet.Size = new System.Drawing.Size(110, 33);
            this.TimeSet.TabIndex = 6;
            this.TimeSet.SelectedIndexChanged += new System.EventHandler(this.TimeSet_SelectedIndexChanged);
            // 
            // SpeedSet
            // 
            this.SpeedSet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SpeedSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpeedSet.FormattingEnabled = true;
            this.SpeedSet.Location = new System.Drawing.Point(308, 172);
            this.SpeedSet.Name = "SpeedSet";
            this.SpeedSet.Size = new System.Drawing.Size(118, 33);
            this.SpeedSet.TabIndex = 7;
            this.SpeedSet.SelectedIndexChanged += new System.EventHandler(this.SpeedSet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "More or less seconds";
            // 
            // Less
            // 
            this.Less.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Less.Location = new System.Drawing.Point(465, 172);
            this.Less.Name = "Less";
            this.Less.Size = new System.Drawing.Size(45, 34);
            this.Less.TabIndex = 9;
            this.Less.Text = "<";
            this.Less.UseVisualStyleBackColor = true;
            this.Less.Click += new System.EventHandler(this.Less_Click);
            // 
            // More
            // 
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.More.Location = new System.Drawing.Point(516, 170);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(45, 34);
            this.More.TabIndex = 9;
            this.More.Text = ">";
            this.More.UseVisualStyleBackColor = true;
            this.More.Click += new System.EventHandler(this.More_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(66, 27);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(41, 38);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "...";
            // 
            // HH
            // 
            this.HH.Location = new System.Drawing.Point(194, 81);
            this.HH.Name = "HH";
            this.HH.Size = new System.Drawing.Size(51, 31);
            this.HH.TabIndex = 11;
            this.HH.Text = "hh";
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(267, 81);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(51, 31);
            this.mm.TabIndex = 11;
            this.mm.Text = "mm";
            this.mm.TextChanged += new System.EventHandler(this.mm_TextChanged);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(342, 81);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(51, 31);
            this.ss.TabIndex = 11;
            this.ss.Text = "ss";
            this.ss.TextChanged += new System.EventHandler(this.ss_TextChanged);
            // 
            // ff
            // 
            this.ff.Location = new System.Drawing.Point(416, 81);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(51, 31);
            this.ff.TabIndex = 11;
            this.ff.Text = "ff";
            // 
            // Set
            // 
            this.Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Set.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Set.Location = new System.Drawing.Point(490, 81);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(52, 31);
            this.Set.TabIndex = 12;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = false;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(627, 240);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.HH);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.More);
            this.Controls.Add(this.Less);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedSet);
            this.Controls.Add(this.TimeSet);
            this.Controls.Add(this.SetMode);
            this.Controls.Add(this.Invert);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAct);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Test timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAct;
        private Button btnReset;
        private CheckBox Show;
        public System.Windows.Forms.Timer timer1;
        private CheckBox Invert;
        private ComboBox SetMode;
        private ComboBox TimeSet;
        private ComboBox SpeedSet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Less;
        private Button More;
        private Label lblTimer;
        private TextBox HH;
        private TextBox mm;
        private TextBox ss;
        private TextBox ff;
        private Button Set;
    }
}