namespace difficultyGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.easyButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.usernameInputLabel = new System.Windows.Forms.Label();
            this.usernameOutputAndDifficultyOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.LightGreen;
            this.easyButton.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.Location = new System.Drawing.Point(21, 156);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(197, 106);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.Color.LightBlue;
            this.normalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalButton.Location = new System.Drawing.Point(296, 156);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(197, 106);
            this.normalButton.TabIndex = 1;
            this.normalButton.Text = "Normal";
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.DarkRed;
            this.hardButton.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(570, 156);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(197, 106);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "HARD";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(421, 37);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "The Difficulty Settings Game";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(138, 88);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(309, 20);
            this.usernameInput.TabIndex = 4;
            // 
            // usernameInputLabel
            // 
            this.usernameInputLabel.AutoSize = true;
            this.usernameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInputLabel.Location = new System.Drawing.Point(16, 83);
            this.usernameInputLabel.Name = "usernameInputLabel";
            this.usernameInputLabel.Size = new System.Drawing.Size(116, 25);
            this.usernameInputLabel.TabIndex = 5;
            this.usernameInputLabel.Text = "Username:";
            // 
            // usernameOutputAndDifficultyOutput
            // 
            this.usernameOutputAndDifficultyOutput.AutoSize = true;
            this.usernameOutputAndDifficultyOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameOutputAndDifficultyOutput.Location = new System.Drawing.Point(12, 484);
            this.usernameOutputAndDifficultyOutput.Name = "usernameOutputAndDifficultyOutput";
            this.usernameOutputAndDifficultyOutput.Size = new System.Drawing.Size(771, 33);
            this.usernameOutputAndDifficultyOutput.TabIndex = 6;
            this.usernameOutputAndDifficultyOutput.Text = "Who are you and what game mode do you want to play in?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(473, 92);
            this.button1.TabIndex = 7;
            this.button1.Text = "Begin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameOutputAndDifficultyOutput);
            this.Controls.Add(this.usernameInputLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.easyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Difficulty Settings Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label usernameInputLabel;
        private System.Windows.Forms.Label usernameOutputAndDifficultyOutput;
        private System.Windows.Forms.Button button1;
    }
}

