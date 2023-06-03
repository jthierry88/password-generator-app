namespace PasswordGenerator
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthSlider = new System.Windows.Forms.TrackBar();
            this.copyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Leelawadee", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(229, 99);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(832, 98);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "label1";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.Font = new System.Drawing.Font("Leelawadee", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthLabel.Location = new System.Drawing.Point(334, 327);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(614, 98);
            this.passwordLengthLabel.TabIndex = 1;
            this.passwordLengthLabel.Text = "Password Length: 5";
            this.passwordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Location = new System.Drawing.Point(346, 413);
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(602, 80);
            this.passwordLengthSlider.TabIndex = 2;
            this.passwordLengthSlider.Scroll += new System.EventHandler(this.passwordLengthSlider_Scroll);
            // 
            // copyPasswordButton
            // 
            this.copyPasswordButton.BackColor = System.Drawing.Color.White;
            this.copyPasswordButton.Font = new System.Drawing.Font("Leelawadee", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPasswordButton.Location = new System.Drawing.Point(346, 499);
            this.copyPasswordButton.Name = "copyPasswordButton";
            this.copyPasswordButton.Size = new System.Drawing.Size(602, 76);
            this.copyPasswordButton.TabIndex = 3;
            this.copyPasswordButton.Text = "Copy Password";
            this.copyPasswordButton.UseVisualStyleBackColor = false;
            this.copyPasswordButton.Click += new System.EventHandler(this.copyPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1290, 664);
            this.Controls.Add(this.copyPasswordButton);
            this.Controls.Add(this.passwordLengthSlider);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TrackBar passwordLengthSlider;
        private System.Windows.Forms.Button copyPasswordButton;
    }
}

