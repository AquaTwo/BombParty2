namespace BombParty2
{
    partial class game
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.bombTimerLabel = new System.Windows.Forms.Label();
            this.bombTimer = new System.Windows.Forms.Timer(this.components);
            this.promptInput = new System.Windows.Forms.TextBox();
            this.livesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promptLabel.AutoSize = true;
            this.promptLabel.BackColor = System.Drawing.Color.Red;
            this.promptLabel.Location = new System.Drawing.Point(394, 112);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(13, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "  ";
            // 
            // bombTimerLabel
            // 
            this.bombTimerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bombTimerLabel.AutoSize = true;
            this.bombTimerLabel.BackColor = System.Drawing.Color.Red;
            this.bombTimerLabel.Location = new System.Drawing.Point(394, 237);
            this.bombTimerLabel.Name = "bombTimerLabel";
            this.bombTimerLabel.Size = new System.Drawing.Size(13, 13);
            this.bombTimerLabel.TabIndex = 1;
            this.bombTimerLabel.Text = "7";
            // 
            // bombTimer
            // 
            this.bombTimer.Interval = 1000;
            this.bombTimer.Tick += new System.EventHandler(this.bombTimer_Tick);
            // 
            // promptInput
            // 
            this.promptInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promptInput.Location = new System.Drawing.Point(350, 211);
            this.promptInput.Name = "promptInput";
            this.promptInput.Size = new System.Drawing.Size(100, 20);
            this.promptInput.TabIndex = 2;
            this.promptInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.promptInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.promptInput_KeyPress);
            // 
            // livesLabel
            // 
            this.livesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.livesLabel.AutoSize = true;
            this.livesLabel.BackColor = System.Drawing.Color.Red;
            this.livesLabel.Location = new System.Drawing.Point(378, 62);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(44, 13);
            this.livesLabel.TabIndex = 3;
            this.livesLabel.Text = "Lives: 3";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.promptInput);
            this.Controls.Add(this.bombTimerLabel);
            this.Controls.Add(this.promptLabel);
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label bombTimerLabel;
        private System.Windows.Forms.Timer bombTimer;
        private System.Windows.Forms.TextBox promptInput;
        private System.Windows.Forms.Label livesLabel;
    }
}