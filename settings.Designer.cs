namespace BombParty2
{
    partial class settings
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
            this.livesLabel = new System.Windows.Forms.Label();
            this.livesValue = new System.Windows.Forms.NumericUpDown();
            this.bombDuration = new System.Windows.Forms.NumericUpDown();
            this.timerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Location = new System.Drawing.Point(384, 94);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(32, 13);
            this.livesLabel.TabIndex = 1;
            this.livesLabel.Text = "Lives";
            // 
            // livesValue
            // 
            this.livesValue.Location = new System.Drawing.Point(340, 138);
            this.livesValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.livesValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.livesValue.Name = "livesValue";
            this.livesValue.Size = new System.Drawing.Size(120, 20);
            this.livesValue.TabIndex = 0;
            this.livesValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.livesValue.ValueChanged += new System.EventHandler(this.livesValue_ValueChanged);
            // 
            // bombDuration
            // 
            this.bombDuration.Location = new System.Drawing.Point(340, 237);
            this.bombDuration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bombDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bombDuration.Name = "bombDuration";
            this.bombDuration.Size = new System.Drawing.Size(120, 20);
            this.bombDuration.TabIndex = 1;
            this.bombDuration.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.bombDuration.ValueChanged += new System.EventHandler(this.bombDuration_ValueChanged);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(369, 193);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(63, 13);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "Bomb Timer";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bombDuration);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.livesValue);
            this.Controls.Add(this.livesLabel);
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.livesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.NumericUpDown livesValue;
        private System.Windows.Forms.NumericUpDown bombDuration;
        private System.Windows.Forms.Label timerLabel;
    }
}