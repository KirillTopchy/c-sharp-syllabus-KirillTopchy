namespace Sudoku
{
    partial class Sudoku
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
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkResultButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(583, 131);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(83, 25);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.DifficultyButtonClick);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(583, 162);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(83, 25);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.DifficultyButtonClick);
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(583, 193);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(83, 25);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.DifficultyButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // checkResultButton
            // 
            this.checkResultButton.Location = new System.Drawing.Point(583, 247);
            this.checkResultButton.Name = "checkResultButton";
            this.checkResultButton.Size = new System.Drawing.Size(83, 53);
            this.checkResultButton.TabIndex = 4;
            this.checkResultButton.Text = "Check Result";
            this.checkResultButton.UseVisualStyleBackColor = true;
            this.checkResultButton.Click += new System.EventHandler(this.CheckResultButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(583, 306);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 53);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 490);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkResultButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkResultButton;
        private System.Windows.Forms.Button clearButton;
    }
}

