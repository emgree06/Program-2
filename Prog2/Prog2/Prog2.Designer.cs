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
            this.seniorButton = new System.Windows.Forms.RadioButton();
            this.juniorButton = new System.Windows.Forms.RadioButton();
            this.sophomoreButton = new System.Windows.Forms.RadioButton();
            this.freshmanButton = new System.Windows.Forms.RadioButton();
            this.classStanding = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.regCalculatorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seniorButton
            // 
            this.seniorButton.AutoSize = true;
            this.seniorButton.Location = new System.Drawing.Point(100, 52);
            this.seniorButton.Name = "seniorButton";
            this.seniorButton.Size = new System.Drawing.Size(55, 17);
            this.seniorButton.TabIndex = 0;
            this.seniorButton.TabStop = true;
            this.seniorButton.Text = "Senior";
            this.seniorButton.UseVisualStyleBackColor = true;
            // 
            // juniorButton
            // 
            this.juniorButton.AutoSize = true;
            this.juniorButton.Location = new System.Drawing.Point(100, 75);
            this.juniorButton.Name = "juniorButton";
            this.juniorButton.Size = new System.Drawing.Size(53, 17);
            this.juniorButton.TabIndex = 1;
            this.juniorButton.TabStop = true;
            this.juniorButton.Text = "Junior";
            this.juniorButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreButton
            // 
            this.sophomoreButton.AutoSize = true;
            this.sophomoreButton.Location = new System.Drawing.Point(98, 98);
            this.sophomoreButton.Name = "sophomoreButton";
            this.sophomoreButton.Size = new System.Drawing.Size(79, 17);
            this.sophomoreButton.TabIndex = 2;
            this.sophomoreButton.TabStop = true;
            this.sophomoreButton.Text = "Sophomore";
            this.sophomoreButton.UseVisualStyleBackColor = true;
            // 
            // freshmanButton
            // 
            this.freshmanButton.AutoSize = true;
            this.freshmanButton.Location = new System.Drawing.Point(98, 121);
            this.freshmanButton.Name = "freshmanButton";
            this.freshmanButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanButton.TabIndex = 3;
            this.freshmanButton.TabStop = true;
            this.freshmanButton.Text = "Freshman";
            this.freshmanButton.UseVisualStyleBackColor = true;
            // 
            // classStanding
            // 
            this.classStanding.AutoSize = true;
            this.classStanding.Location = new System.Drawing.Point(12, 36);
            this.classStanding.Name = "classStanding";
            this.classStanding.Size = new System.Drawing.Size(110, 13);
            this.classStanding.TabIndex = 4;
            this.classStanding.Text = "Select class standing:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 153);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Enter last name:";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(98, 169);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 6;
            this.lastNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // regCalculatorButton
            // 
            this.regCalculatorButton.Location = new System.Drawing.Point(112, 220);
            this.regCalculatorButton.Name = "regCalculatorButton";
            this.regCalculatorButton.Size = new System.Drawing.Size(75, 23);
            this.regCalculatorButton.TabIndex = 7;
            this.regCalculatorButton.Text = "Calculate";
            this.regCalculatorButton.UseVisualStyleBackColor = true;
            this.regCalculatorButton.Click += new System.EventHandler(this.regCalculatorButton_Click);
            // 
            // Prog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.regCalculatorButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.classStanding);
            this.Controls.Add(this.freshmanButton);
            this.Controls.Add(this.sophomoreButton);
            this.Controls.Add(this.juniorButton);
            this.Controls.Add(this.seniorButton);
            this.Name = "Prog2";
            this.Text = "Registration Date Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton seniorButton;
        private System.Windows.Forms.RadioButton juniorButton;
        private System.Windows.Forms.RadioButton sophomoreButton;
        private System.Windows.Forms.RadioButton freshmanButton;
        private System.Windows.Forms.Label classStanding;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button regCalculatorButton;
    }
}

