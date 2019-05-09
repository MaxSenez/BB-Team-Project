namespace BrickBreaker
{
    partial class HighScoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displaylabel = new System.Windows.Forms.Label();
            this.highScores = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displaylabel
            // 
            this.displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaylabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displaylabel.Location = new System.Drawing.Point(1121, 193);
            this.displaylabel.Name = "displaylabel";
            this.displaylabel.Size = new System.Drawing.Size(503, 126);
            this.displaylabel.TabIndex = 0;
            this.displaylabel.Text = "High Scores";
            // 
            // highScores
            // 
            this.highScores.Font = new System.Drawing.Font("Museo Sans For Dell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.highScores.Location = new System.Drawing.Point(949, 391);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(841, 969);
            this.highScores.TabIndex = 1;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Silver;
            this.continueButton.Font = new System.Drawing.Font("Museo Sans For Dell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(49, 1416);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(700, 102);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Click this to continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.highScores);
            this.Controls.Add(this.displaylabel);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(2535, 1565);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displaylabel;
        private System.Windows.Forms.Label highScores;
        private System.Windows.Forms.Button continueButton;
    }
}
