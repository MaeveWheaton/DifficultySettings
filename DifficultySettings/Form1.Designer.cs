
namespace DifficultySettings
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
            this.heroLabel = new System.Windows.Forms.Label();
            this.heroNameInput = new System.Windows.Forms.TextBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heroLabel
            // 
            this.heroLabel.AutoSize = true;
            this.heroLabel.Font = new System.Drawing.Font("Segoe UI Historic", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroLabel.ForeColor = System.Drawing.Color.White;
            this.heroLabel.Location = new System.Drawing.Point(23, 130);
            this.heroLabel.Name = "heroLabel";
            this.heroLabel.Size = new System.Drawing.Size(428, 51);
            this.heroLabel.TabIndex = 0;
            this.heroLabel.Text = "Enter Your Hero Name:";
            // 
            // heroNameInput
            // 
            this.heroNameInput.BackColor = System.Drawing.Color.White;
            this.heroNameInput.Font = new System.Drawing.Font("Segoe UI Historic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroNameInput.Location = new System.Drawing.Point(526, 124);
            this.heroNameInput.MinimumSize = new System.Drawing.Size(541, 57);
            this.heroNameInput.Name = "heroNameInput";
            this.heroNameInput.Size = new System.Drawing.Size(541, 57);
            this.heroNameInput.TabIndex = 1;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Segoe UI Historic", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.ForeColor = System.Drawing.Color.White;
            this.difficultyLabel.Location = new System.Drawing.Point(337, 300);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(400, 51);
            this.difficultyLabel.TabIndex = 2;
            this.difficultyLabel.Text = "Select Your Difficulty:";
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.easyButton.FlatAppearance.BorderSize = 2;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Segoe UI Historic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(65, 387);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(246, 92);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Black;
            this.mediumButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mediumButton.FlatAppearance.BorderSize = 2;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Segoe UI Historic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(409, 387);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(246, 92);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Black;
            this.hardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hardButton.FlatAppearance.BorderSize = 2;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Segoe UI Historic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(752, 387);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(246, 92);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.Black;
            this.beginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.beginButton.FlatAppearance.BorderSize = 2;
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Segoe UI Historic", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.Color.White;
            this.beginButton.Location = new System.Drawing.Point(346, 538);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(373, 92);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessageLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(57, 744);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(992, 150);
            this.welcomeMessageLabel.TabIndex = 7;
            this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1115, 1014);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.heroNameInput);
            this.Controls.Add(this.heroLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hero Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroLabel;
        private System.Windows.Forms.TextBox heroNameInput;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label welcomeMessageLabel;
    }
}

