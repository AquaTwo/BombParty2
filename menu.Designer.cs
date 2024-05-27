namespace BombParty2
{
    partial class main
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
            this.playGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playGameButton
            // 
            this.playGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playGameButton.Location = new System.Drawing.Point(297, 178);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(207, 95);
            this.playGameButton.TabIndex = 0;
            this.playGameButton.Text = "Play";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playGameButton);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playGameButton;
    }
}

