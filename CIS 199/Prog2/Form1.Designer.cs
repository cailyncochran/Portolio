namespace Prog2
{
    partial class Prog2
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
            this.uOfLLabel = new System.Windows.Forms.Label();
            this.priorityRegLabel = new System.Windows.Forms.Label();
            this.completedHoursLabel = new System.Windows.Forms.Label();
            this.enterCompletedHoursTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.enterFirstLetterTextbox = new System.Windows.Forms.TextBox();
            this.clickBelowLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uOfLLabel
            // 
            this.uOfLLabel.AutoSize = true;
            this.uOfLLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uOfLLabel.ForeColor = System.Drawing.Color.Red;
            this.uOfLLabel.Location = new System.Drawing.Point(87, 9);
            this.uOfLLabel.Name = "uOfLLabel";
            this.uOfLLabel.Size = new System.Drawing.Size(219, 21);
            this.uOfLLabel.TabIndex = 0;
            this.uOfLLabel.Text = "University of Louisville";
            // 
            // priorityRegLabel
            // 
            this.priorityRegLabel.AutoSize = true;
            this.priorityRegLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityRegLabel.Location = new System.Drawing.Point(80, 30);
            this.priorityRegLabel.Name = "priorityRegLabel";
            this.priorityRegLabel.Size = new System.Drawing.Size(226, 15);
            this.priorityRegLabel.TabIndex = 1;
            this.priorityRegLabel.Text = "Priority Registration Spring 2017";
            // 
            // completedHoursLabel
            // 
            this.completedHoursLabel.AutoSize = true;
            this.completedHoursLabel.Location = new System.Drawing.Point(12, 85);
            this.completedHoursLabel.Name = "completedHoursLabel";
            this.completedHoursLabel.Size = new System.Drawing.Size(199, 13);
            this.completedHoursLabel.TabIndex = 2;
            this.completedHoursLabel.Text = "Enter Completed Hours Before Fall 2016:";
            // 
            // enterCompletedHoursTextBox
            // 
            this.enterCompletedHoursTextBox.Location = new System.Drawing.Point(239, 82);
            this.enterCompletedHoursTextBox.Name = "enterCompletedHoursTextBox";
            this.enterCompletedHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterCompletedHoursTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 147);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(153, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Enter First Letter of Last Name:";
            // 
            // enterFirstLetterTextbox
            // 
            this.enterFirstLetterTextbox.Location = new System.Drawing.Point(239, 144);
            this.enterFirstLetterTextbox.Name = "enterFirstLetterTextbox";
            this.enterFirstLetterTextbox.Size = new System.Drawing.Size(36, 20);
            this.enterFirstLetterTextbox.TabIndex = 5;
            // 
            // clickBelowLabel
            // 
            this.clickBelowLabel.AutoSize = true;
            this.clickBelowLabel.Location = new System.Drawing.Point(50, 192);
            this.clickBelowLabel.Name = "clickBelowLabel";
            this.clickBelowLabel.Size = new System.Drawing.Size(287, 13);
            this.clickBelowLabel.TabIndex = 6;
            this.clickBelowLabel.Text = "Click Below To See Your Earliest Date/Time of Registration";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(135, 219);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(104, 23);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Registration Date";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Prog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 273);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.clickBelowLabel);
            this.Controls.Add(this.enterFirstLetterTextbox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.enterCompletedHoursTextBox);
            this.Controls.Add(this.completedHoursLabel);
            this.Controls.Add(this.priorityRegLabel);
            this.Controls.Add(this.uOfLLabel);
            this.Name = "Prog2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uOfLLabel;
        private System.Windows.Forms.Label priorityRegLabel;
        private System.Windows.Forms.Label completedHoursLabel;
        private System.Windows.Forms.TextBox enterCompletedHoursTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox enterFirstLetterTextbox;
        private System.Windows.Forms.Label clickBelowLabel;
        private System.Windows.Forms.Button registerButton;
    }
}

