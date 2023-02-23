namespace LeagueBot
{
    partial class Logger
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
            this.LoggerText = new System.Windows.Forms.RichTextBox();
            this.gameStateTimer = new System.Windows.Forms.Timer(this.components);
            this.ChatTimer = new System.Windows.Forms.Timer(this.components);
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.checkMatch = new System.Windows.Forms.CheckBox();
            this.tmrLobby = new System.Windows.Forms.Timer(this.components);
            this.comboPick = new System.Windows.Forms.ComboBox();
            this.checkPick = new System.Windows.Forms.CheckBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LoggerText
            // 
            this.LoggerText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoggerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoggerText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LoggerText.Location = new System.Drawing.Point(156, 42);
            this.LoggerText.Name = "LoggerText";
            this.LoggerText.ReadOnly = true;
            this.LoggerText.Size = new System.Drawing.Size(102, 24);
            this.LoggerText.TabIndex = 0;
            this.LoggerText.Text = "";
            this.LoggerText.Visible = false;
            // 
            // gameStateTimer
            // 
            this.gameStateTimer.Enabled = true;
            this.gameStateTimer.Interval = 1000;
            this.gameStateTimer.Tick += new System.EventHandler(this.gameStateTimer_Tick);
            // 
            // ChatTimer
            // 
            this.ChatTimer.Enabled = true;
            this.ChatTimer.Interval = 500;
            this.ChatTimer.Tick += new System.EventHandler(this.ChatTimer_Tick);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(26, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(118, 30);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Teal;
            this.btnAccept.Enabled = false;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(150, 12);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(116, 30);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // checkMatch
            // 
            this.checkMatch.AutoSize = true;
            this.checkMatch.Location = new System.Drawing.Point(26, 49);
            this.checkMatch.Name = "checkMatch";
            this.checkMatch.Size = new System.Drawing.Size(118, 17);
            this.checkMatch.TabIndex = 15;
            this.checkMatch.Text = "Auto Accept Match";
            this.checkMatch.UseVisualStyleBackColor = true;
            this.checkMatch.CheckedChanged += new System.EventHandler(this.checkMatch_CheckedChanged);
            // 
            // tmrLobby
            // 
            this.tmrLobby.Enabled = true;
            this.tmrLobby.Interval = 400;
            this.tmrLobby.Tick += new System.EventHandler(this.tmrLobby_Tick);
            // 
            // comboPick
            // 
            this.comboPick.FormattingEnabled = true;
            this.comboPick.Location = new System.Drawing.Point(26, 72);
            this.comboPick.Name = "comboPick";
            this.comboPick.Size = new System.Drawing.Size(240, 21);
            this.comboPick.TabIndex = 19;
            // 
            // checkPick
            // 
            this.checkPick.AutoSize = true;
            this.checkPick.Location = new System.Drawing.Point(186, 99);
            this.checkPick.Name = "checkPick";
            this.checkPick.Size = new System.Drawing.Size(72, 17);
            this.checkPick.TabIndex = 20;
            this.checkPick.Text = "Auto Pick";
            this.checkPick.UseVisualStyleBackColor = true;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(26, 99);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(154, 23);
            this.btnPick.TabIndex = 21;
            this.btnPick.Text = "Pick Champion";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 500;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 144);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.checkPick);
            this.Controls.Add(this.comboPick);
            this.Controls.Add(this.checkMatch);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.LoggerText);
            this.Name = "Logger";
            this.Text = "YK\'s League AUTOSTARTER";
            this.Load += new System.EventHandler(this.Logger_Load);
            this.Shown += new System.EventHandler(this.Logger_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LoggerText;
        private System.Windows.Forms.Timer gameStateTimer;
        private System.Windows.Forms.Timer ChatTimer;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.CheckBox checkMatch;
        private System.Windows.Forms.Timer tmrLobby;
        private System.Windows.Forms.ComboBox comboPick;
        private System.Windows.Forms.CheckBox checkPick;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Timer gameTimer;
    }
}

