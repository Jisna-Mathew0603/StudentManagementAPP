namespace WinForms.StudentManagemntSystemAS3
{
    partial class Login
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
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.button2exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(435, 175);
            this.usernametxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(208, 31);
            this.usernametxtbox.TabIndex = 0;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(435, 317);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(208, 31);
            this.passwordtextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(252, 317);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(140, 25);
            this.label.TabIndex = 3;
            this.label.Text = "PASSWORD:";
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.Location = new System.Drawing.Point(501, 483);
            this.Loginbutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(164, 54);
            this.Loginbutton1.TabIndex = 4;
            this.Loginbutton1.Text = "LOGIN";
            this.Loginbutton1.UseVisualStyleBackColor = true;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // button2exit
            // 
            this.button2exit.Location = new System.Drawing.Point(694, 491);
            this.button2exit.Name = "button2exit";
            this.button2exit.Size = new System.Drawing.Size(182, 46);
            this.button2exit.TabIndex = 6;
            this.button2exit.Text = "&EXIT";
            this.button2exit.UseVisualStyleBackColor = true;
            this.button2exit.Click += new System.EventHandler(this.button2exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 597);
            this.Controls.Add(this.button2exit);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametxtbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Loginbutton1;
        private System.Windows.Forms.Button button2exit;
    }
}

