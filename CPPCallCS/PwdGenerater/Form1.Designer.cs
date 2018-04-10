namespace PwdGenerater
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generatePwdButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(76, 30);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(301, 20);
            this.usernameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // generatePwdButton
            // 
            this.generatePwdButton.Location = new System.Drawing.Point(76, 80);
            this.generatePwdButton.Name = "generatePwdButton";
            this.generatePwdButton.Size = new System.Drawing.Size(117, 23);
            this.generatePwdButton.TabIndex = 3;
            this.generatePwdButton.Text = "Generate Password";
            this.generatePwdButton.UseVisualStyleBackColor = true;
            this.generatePwdButton.Click += new System.EventHandler(this.generatePwdButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(76, 127);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.ReadOnly = true;
            this.passwordTextbox.Size = new System.Drawing.Size(301, 20);
            this.passwordTextbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 196);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.generatePwdButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Password Generater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generatePwdButton;
        private System.Windows.Forms.TextBox passwordTextbox;
    }
}

